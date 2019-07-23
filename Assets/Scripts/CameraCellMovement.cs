using UnityEngine;
using System.Collections;

public class CameraCellMovement : MonoBehaviour
{
    [SerializeField]
    private float lerp = 0.6f;
    [SerializeField]
    private GameManager gameManager = null;
    [SerializeField]
    private BlockManager blockManager = null;
    [SerializeField]
    MultiplayerInitializer multiplayerInitializer = null;

    private Vector3 targetPosition;

    private void Awake()
    {
        gameManager.GoingHigher += MoveUp;
        multiplayerInitializer.OnInitialized += Instance_OnInitialized;
    }

    private void Instance_OnInitialized()
    {
        targetPosition = transform.position;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, lerp);
    }

    private void MoveUp(int y)
    {
        targetPosition.y = blockManager.CellPositionToGlobal(new Vector2Int(0, y)).y;
    }
}
