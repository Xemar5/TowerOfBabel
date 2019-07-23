using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public partial class BlockManager : MonoBehaviour
{
    [SerializeField]
    private new Camera camera = null;
    [SerializeField]
    private GameObject wallTilePrefab;
    [SerializeField]
    private GameObject hazardTilePrefab;
    [SerializeField]
    private GameObject finishLineTilePrefab;
    [SerializeField]
    private GameObject bombTilePrefab;
    [SerializeField]
    MultiplayerInitializer multiplayerInitializer = null;
    [SerializeField]
    private ScreenShake screenShake = null;
    [SerializeField]
    private DestroyParticlesManager destroyParticlesManager = null;

    [SerializeField]
    public BlockDefinition[] blockDefinitions = null;
    [SerializeField]
    private ColorCellDefinition[] colorCellDefinitions = null;


    private Cell[,] cells;
    private List<Cell> collectibles = new List<Cell>();
    private Tilemap tilemap;


    public int Height { get; private set; }
    public int Width { get; private set; }


    private void Awake()
    {
        MultiplayerInitializer.OnBomb += DestroyRandomOnScreen;
    }
    private void OnDestroy()
    {
        MultiplayerInitializer.OnBomb -= DestroyRandomOnScreen;
    }

    public void Generate(int width, int height, Tilemap tilemap)
    {
        this.Height = height;
        this.Width = width;
        cells = new Cell[width, height];
        this.tilemap = tilemap;
        BuildWalls(tilemap);
        BuildHazards(tilemap);
        BuildFinishLine(tilemap);
        BuildBomb(tilemap);
    }
    private void BuildWalls(Tilemap tilemap)
    {
        List<Cell> cellList = GetCells(tilemap, wallTilePrefab);
        foreach (Cell cell in cellList)
        {
            cell.transform.SetParent(transform);
            cell.SetProperties(false, true, false);
            cells[cell.TargetPivotPosition.x, cell.TargetPivotPosition.y] = cell;
        }
    }
    private void BuildHazards(Tilemap tilemap)
    {
        List<Cell> cellList = GetCells(tilemap, hazardTilePrefab);
        foreach (Cell cell in cellList)
        {
            cell.transform.SetParent(transform);
            cell.SetProperties(true, true, false);
            cell.IsHazard = true;
            cells[cell.TargetPivotPosition.x, cell.TargetPivotPosition.y] = cell;
        }
    }
    private void BuildFinishLine(Tilemap tilemap)
    {
        List<Cell> cellList = GetCells(tilemap, finishLineTilePrefab);
        foreach (Cell cell in cellList)
        {
            cell.transform.SetParent(transform);
            cell.SetProperties(false, true, true);
            cell.IsFinishLine = true;
            collectibles.Add(cell);
        }
    }
    private void BuildBomb(Tilemap tilemap)
    {
        List<Cell> cellList = GetCells(tilemap, bombTilePrefab);
        foreach (Cell cell in cellList)
        {
            cell.transform.SetParent(transform);
            cell.SetProperties(false, true, true);
            cell.IsBomb = true;
            collectibles.Add(cell);
        }
    }
    public List<Cell> GetCells(Tilemap tilemap, GameObject tilePrefab)
    {
        List<Cell> cellList = new List<Cell>();
        Vector3Int pos = Vector3Int.zero;
        for (int i = tilemap.cellBounds.min.x; i < tilemap.cellBounds.max.x; i++)
        {
            for (int j = tilemap.cellBounds.min.y; j < tilemap.cellBounds.max.y; j++)
            {
                pos.x = i;
                pos.y = j;
                RuleTile ruleTile = tilemap.GetTile<RuleTile>(pos);
                if (ruleTile != null)
                {
                    if (ruleTile.m_DefaultGameObject == tilePrefab)
                    {
                        Cell cell = new GameObject(tilePrefab.name).AddComponent<Cell>();
                        cell.cellPosToGlobal = CellPositionToGlobal;
                        Vector2Int cellPosition = new Vector2Int(i - tilemap.cellBounds.min.x, j - tilemap.cellBounds.min.y);
                        cell.Initialize(null, Vector2Int.zero, cellPosition, 0);
                        cellList.Add(cell);
                    }
                }
            }
        }
        return cellList;
    }



    public Block AddBlock(PlayerColor playerColor, BlockDefinition blockDefinition, Vector2Int startingCellPosition)
    {
        Block block = new GameObject("Block").AddComponent<Block>();
        block.transform.SetParent(transform);
        block.Initialize(startingCellPosition, playerColor, blockDefinition, colorCellDefinitions[playerColor.ToIndex()], CellPositionToGlobal, multiplayerInitializer.random);

        return block;
    }
    public void StartBlock(Block block)
    {
        StartCoroutine(SetBlockPosition(block));
    }

    private IEnumerator SetBlockPosition(Block block)
    {
        while (true)
        {
            bool allGood = true;
            foreach (Cell cell in block.cells)
            {
                Vector2Int cellPosition = cell.TargetPivotPosition + cell.PivotOffset;
                if (cells[cellPosition.x, cellPosition.y] != null)
                {
                    allGood = false;
                    break;
                }
            }


            if (allGood == false)
            {
                // Something is blocking a cell
                block.SetProperties(false, false, true);
                yield return null;
            }
            else
            {
                // Block can be placed
                foreach (Cell cell in block.cells)
                {
                    Vector2Int cellPosition = cell.TargetPivotPosition + cell.PivotOffset;
                    cells[cellPosition.x, cellPosition.y] = cell;
                }
                block.SetProperties(true, true, false);
                block.InvokeStarted();

                yield break;
            }
        }
    }

    public void DestroyRandomOnScreen(int sceneIndex, PlayerColor opponent, int bombDestroyCount)
    {
        if (multiplayerInitializer.SceneIndex == sceneIndex)
        {
            return;
        }

        screenShake.Play();

        Vector3 cameraMin = camera.ViewportToWorldPoint(new Vector3(0, 0, camera.nearClipPlane));
        Vector3 cameraMax = camera.ViewportToWorldPoint(new Vector3(1, 1, camera.nearClipPlane));
        Vector2Int min = GlobalToCellPosition(cameraMin);
        Vector2Int max = GlobalToCellPosition(cameraMax);

        List<Cell> opponentCells = new List<Cell>();
        for (int i = min.x; i < max.x; i++)
        {
            for (int j = min.y; j < max.y; j++)
            {
                if (cells[i, j] != null &&
                    cells[i, j].ParentBlock != null &&
                    cells[i, j].Alive == false &&
                    opponent.HasFlag(cells[i, j].ParentBlock.PlayerColor) == true)
                {
                    opponentCells.Add(cells[i, j]);
                }
            }
        }

        while (bombDestroyCount > 0 && opponentCells.Count > 0)
        {
            bombDestroyCount -= 1;
            int randomCellIndex = multiplayerInitializer.random.Range(0, opponentCells.Count);
            Cell cell = opponentCells[randomCellIndex];
            cells[cell.ActuallPosition.x, cell.ActuallPosition.y] = null;
            cell.Destroy(destroyParticlesManager);
            opponentCells.RemoveAt(randomCellIndex);
        }
    }

    public MoveOrderOutcome OrderMovement(Block block, Vector2Int direction)
    {
        if (block.IsAlive == false)
        {
            return MoveOrderOutcome.CallerNotAlive;
        }
        List<Vector2Int> peekPositions = block.PeekPerformMovement(direction);
        var moveOrderOutcome = PeekOrder(block, peekPositions);
        if (moveOrderOutcome == MoveOrderOutcome.Moved)
        {
            PerformOrder(block, peekPositions);
            block.PerformMovement(direction);
        }
        return moveOrderOutcome;
    }
    public MoveOrderOutcome OrderRotation(Block block, bool clockwise)
    {
        if (block.IsAlive == false)
        {
            return MoveOrderOutcome.CallerNotAlive;
        }
        List<Vector2Int> peekPositions = block.PeekPerformRotation(clockwise);
        var moveOrderOutcome = PeekOrder(block, peekPositions);
        if (moveOrderOutcome == MoveOrderOutcome.Moved)
        {
            PerformOrder(block, peekPositions);
            block.PerformRotation(clockwise);
        }
        return moveOrderOutcome;
    }

    private MoveOrderOutcome PeekOrder(Block block, List<Vector2Int> peekPositions)
    {
        bool hazardCollided = false;
        bool otherCollided = false;
        foreach (Vector2Int position in peekPositions)
        {
            if (position.x < 0 || position.x >= cells.GetLength(0)) return MoveOrderOutcome.Collided_Bounds;
            if (position.y >= cells.GetLength(1)) return MoveOrderOutcome.Collided_Bounds;
            if (position.y < 0) return MoveOrderOutcome.Collided_Dead; // We reached the bottom

            Vector2 globalPosition = CellPositionToGlobal(position);
            if (globalPosition.y < camera.ViewportToWorldPoint(Vector3.zero).y)
            {
                // Out of camera bounds. Destroying
                return MoveOrderOutcome.Collided_Hazard;
            }

            Cell cell = cells[position.x, position.y];
            if (cell != null)
            {
                if (cell.PassThrough == true)
                {
                    continue;
                }
                if (cell.ParentBlock == block)
                {
                    continue;
                }
                if (cell.Alive == false)
                {
                    return MoveOrderOutcome.Collided_Dead;
                }
                if (cell.ParentBlock != null && cell.ParentBlock.PlayerColor != block.PlayerColor)
                {
                    otherCollided = true;
                }
                if (cell.IsHazard == true)
                {
                    hazardCollided = true;
                }
            }
        }

        if (otherCollided == true)
        {
            return MoveOrderOutcome.Collided_Alive;
        }
        if (hazardCollided == true)
        {
            return MoveOrderOutcome.Collided_Hazard;
        }
        else
        {
            return MoveOrderOutcome.Moved;
        }
    }

    public List<CollectibleType> PlacedOnCollectible(Block block)
    {
        List<CollectibleType> collectibleTypes = new List<CollectibleType>();
        List<Cell> toRemoveCells = new List<Cell>();
        foreach (Cell cell in block.cells)
        {
            foreach (Cell collectible in collectibles)
            {
                if (cell.ActuallPosition == collectible.ActuallPosition)
                {
                    if (collectible.IsFinishLine == true)
                    {
                        return new List<CollectibleType>() { CollectibleType.FinishLine };
                    }
                    if (collectible.IsBomb == true)
                    {
                        collectibleTypes.Add(CollectibleType.Bomb);
                        toRemoveCells.Add(collectible);
                    }
                }
            }
        }

        for (int i = 0; i < toRemoveCells.Count; i++)
        {
            toRemoveCells[i].Destroy(destroyParticlesManager);
            collectibles.Remove(toRemoveCells[i]);
        }

        return collectibleTypes;
    }
    private void PerformOrder(Block block, List<Vector2Int> peekPositions)
    {
        for (int i = 0; i < block.cells.Count; i++)
        {
            Cell cell = block.cells[i];
            Vector2Int previousPosition = cell.TargetPivotPosition + cell.PivotOffset;
            if (cells[previousPosition.x, previousPosition.y] == cell)
            {
                cells[previousPosition.x, previousPosition.y] = null;
            }
            cells[peekPositions[i].x, peekPositions[i].y] = cell;
        }
    }


    public Vector2 CellPositionToGlobal(Vector2Int cellPosition)
    {
        return (Vector2)cellPosition + new Vector2(tilemap.cellBounds.xMin, tilemap.cellBounds.yMin) + Vector2.one * 0.5f + (Vector2)tilemap.transform.position;
    }
    public Vector2Int GlobalToCellPosition(Vector2 globalPosition)
    {
        Vector2 cellPosition = globalPosition - (new Vector2(tilemap.cellBounds.xMin, tilemap.cellBounds.yMin) + Vector2.one * 0.5f + (Vector2)tilemap.transform.position);
        return new Vector2Int((int)cellPosition.x, (int)cellPosition.y);
    }
}
