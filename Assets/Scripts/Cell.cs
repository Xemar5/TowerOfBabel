using UnityEngine;
using System.Collections;
using System;

public class Cell : MonoBehaviour
{

    private bool alive;
    private float delay;
    private bool passThrough;
    private Vector2Int targetPivotPosition;
    private Vector2Int pivotOffset;
    private Vector2Int futureTargetPivotPosition;
    private Vector2Int futurePivotOffset;
    private Block parentBlock;
    private SpriteRenderer spriteRenderer;

    public Func<Vector2Int, Vector2> cellPosToGlobal;

    public bool Alive => alive;
    public bool PassThrough => passThrough;
    public bool IsHazard { get; set; }
    public bool IsFinishLine { get; set; }
    public bool IsBomb { get; set; }
    public Vector2Int ActuallPosition => targetPivotPosition + pivotOffset;
    public Vector2Int TargetPivotPosition => targetPivotPosition;
    public Vector2Int PivotOffset => pivotOffset;
    public Block ParentBlock => parentBlock;

    public void Initialize(Block parentBlock, Vector2Int pivotOffset, Vector2Int pivotPosition, float delay)
    {
        this.delay = delay;
        this.pivotOffset = pivotOffset;
        this.futurePivotOffset = pivotOffset;
        this.targetPivotPosition = pivotPosition;
        this.futureTargetPivotPosition = pivotPosition;
        this.parentBlock = parentBlock;
        transform.position = cellPosToGlobal.Invoke(targetPivotPosition + pivotOffset);
    }
    public void SetCellSprite(ColorCellDefinition colorCellDefinition, System.Random random)
    {
        spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        int randomSpriteIndex = random.Range(0, colorCellDefinition.cellSprites.Count);
        Sprite sprite = colorCellDefinition.cellSprites[randomSpriteIndex];
        spriteRenderer.sprite = sprite;
    }

    public void SetProperties(bool alive, bool visible, bool passThrough)
    {
        this.alive = alive;
        this.passThrough = passThrough;
        if (spriteRenderer != null)
        {
            spriteRenderer.enabled = visible;
        }
    }

    public IEnumerator PerformMovement(Vector2Int offset)
    {
        targetPivotPosition += offset;
        yield return new WaitForSeconds(delay);
        futureTargetPivotPosition += offset;
    }
    public IEnumerator PerformRotation(bool clockwise)
    {
        if (clockwise)
        {
            pivotOffset = new Vector2Int(-pivotOffset.y, pivotOffset.x);
        }
        else
        {
            pivotOffset = new Vector2Int(pivotOffset.y, -pivotOffset.x);
        }
        yield return new WaitForSeconds(delay);
        if (clockwise)
        {
            futurePivotOffset = new Vector2Int(-futurePivotOffset.y, futurePivotOffset.x);
        }
        else
        {
            futurePivotOffset = new Vector2Int(futurePivotOffset.y, -futurePivotOffset.x);
        }
    }
    public Vector2Int PeekPerformMovement(Vector2Int offset)
    {
        return targetPivotPosition + offset + pivotOffset;
    }
    public Vector2Int PeekPerformRotation(bool clockwise)
    {
        if (clockwise)
        {
            Vector2Int offset = new Vector2Int(-pivotOffset.y, pivotOffset.x);
            return targetPivotPosition + offset;
        }
        else
        {
            Vector2Int offset = new Vector2Int(pivotOffset.y, -pivotOffset.x);
            return targetPivotPosition + offset;
        }
    }

    public void StartMovement()
    {
        StartCoroutine(MovementCoroutine());
    }
    private IEnumerator MovementCoroutine()
    {
        Vector2 targetPosition = cellPosToGlobal.Invoke(futureTargetPivotPosition + futurePivotOffset);
        while (Alive || Vector2.Distance(targetPosition, transform.position) > 0.001f)
        {
            targetPosition = cellPosToGlobal.Invoke(futureTargetPivotPosition + futurePivotOffset);
            transform.position = Vector2.Lerp(transform.position, targetPosition, 0.3f);
            yield return null;
        }
        yield return null;
        targetPosition = cellPosToGlobal.Invoke(futureTargetPivotPosition + futurePivotOffset);
        transform.position = targetPosition;
    }

    public void Destroy(DestroyParticlesManager destroyParticlesManager)
    {
        Vector2 position = cellPosToGlobal.Invoke(ActuallPosition);
        destroyParticlesManager.Play(position);
        SetProperties(false, false, true);
    }

}
