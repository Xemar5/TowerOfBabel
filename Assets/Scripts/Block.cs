using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public List<Cell> cells = new List<Cell>();
    private PlayerColor playerColor;
    private bool isAlive;

    public PlayerColor PlayerColor => playerColor;
    public bool IsAlive => isAlive;
    public bool IsDestroyed { get; set; }
    public float LastDown { get; set; }

    public event Action<Block> Started;

    public void Initialize(Vector2Int position, PlayerColor playerColor, BlockDefinition blockDefinition, ColorCellDefinition colorCellDefinition, Func<Vector2Int, Vector2> cellPositionToGlobal, System.Random random)
    {
        this.playerColor = playerColor;
        foreach (Vector2Int cellOffset in blockDefinition.cellOffsets)
        {
            Cell cell = new GameObject("Cell").AddComponent<Cell>();
            cell.transform.SetParent(transform);
            cell.cellPosToGlobal = cellPositionToGlobal;
            cell.Initialize(this, cellOffset, position, 0);
            cell.SetCellSprite(colorCellDefinition, random);
            cells.Add(cell);
        }
    }

    public void SetProperties(bool alive, bool visible, bool passThrough)
    {
        isAlive = alive;
        foreach (Cell cell in cells)
        {
            cell.SetProperties(alive, visible, passThrough);
        }
    }
    public void InvokeStarted()
    {
        Started?.Invoke(this);
    }

    public void PerformMovement(Vector2Int direction)
    {
        if (IsAlive == false)
        {
            return;
        }
        foreach (Cell cell in cells)
        {
            StartCoroutine(cell.PerformMovement(direction));
        }
        if (direction.y < 0) // Moving down
        {
            LastDown = Time.time;
        }
    }
    public void PerformRotation(bool clockwise)
    {
        if (IsAlive == false)
        {
            return;
        }
        foreach (Cell cell in cells)
        {
            StartCoroutine(cell.PerformRotation(clockwise));
        }
    }

    public List<Vector2Int> PeekPerformMovement(Vector2Int direction)
    {
        List<Vector2Int> list = new List<Vector2Int>();
        foreach (Cell cell in cells)
        {
            list.Add(cell.PeekPerformMovement(direction));
        }
        return list;
    }
    public List<Vector2Int> PeekPerformRotation(bool clockwise)
    {
        List<Vector2Int> list = new List<Vector2Int>();
        foreach (Cell cell in cells)
        {
            list.Add(cell.PeekPerformRotation(clockwise));
        }
        return list;
    }

    public void StartMovement()
    {
        foreach (Cell cell in cells)
        {
            cell.StartMovement();
        }
    }

    public void Destroy(DestroyParticlesManager destroyParticlesManager)
    {
        if (IsDestroyed == true)
        {
            return;
        }
        IsDestroyed = true;
        foreach (Cell cell in cells)
        {
            cell.Destroy(destroyParticlesManager);
        }
        isAlive = false;
    }
}
