using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using System;

public class GameManager : MonoBehaviour
{
    public float lowerInterval = 1;

    [SerializeField]
    private Tilemap tilemap = null;

    [SerializeField]
    private new Camera camera = null;
    [SerializeField]
    private BlockManager blockManager = null;
    [SerializeField]
    private PlayerManager playerManager = null;
    [SerializeField]
    private SpawnLineManager spawnLineManager = null;
    [SerializeField]
    private MultiplayerInitializer multiplayerInitializer = null;
    [SerializeField]
    private DestroyParticlesManager destroyParticlesManager = null;

    [SerializeField]
    private int bombDestroyCount = 5;

    public Dictionary<PlayerColor, Block> activeBlocks = new Dictionary<PlayerColor, Block>();

    private int highestCell = int.MinValue;
    public event Action<int> GoingHigher;

    private void Awake()
    {
        playerManager.Left += OnLeft;
        playerManager.Right += OnRight;
        playerManager.Down += OnDown;
        playerManager.RotateClockwise += OnRotateClockwise;
        playerManager.RotateCounterClockwise += OnRotateCounterClockwise;
        blockManager.Generate(tilemap.size.x, tilemap.size.y, tilemap);
        MultiplayerInitializer.OnEnd += EndGame;
    }
    private void OnDestroy()
    {
        MultiplayerInitializer.OnEnd -= EndGame;
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(1);

        Vector2Int cameraToCellPosition = blockManager.GlobalToCellPosition(camera.transform.position);
        highestCell = cameraToCellPosition.y;

        foreach (var pair in playerManager.mapToColor)
        {
            RestartPlayer(pair.playerColor);
        }
    }



    private void RestartPlayer(PlayerColor player)
    {
        if (StopPlayer(player) == true)
        {
            PlayerColor team = player.Team();
            multiplayerInitializer.InvokeEnd(team);
            return;
        }
        int randomBlockIndex = multiplayerInitializer.blockRandom.Range(0, blockManager.blockDefinitions.Length);

        Block newBlock = blockManager.AddBlock(player, blockManager.blockDefinitions[randomBlockIndex], spawnLineManager.SpawnPosition);
        newBlock.SetProperties(false, false, true);
        newBlock.Started += BlockStarted;
        blockManager.StartBlock(newBlock);
        activeBlocks[player] = newBlock;
    }

    private bool StopPlayer(PlayerColor player)
    {
        if (activeBlocks.TryGetValue(player, out Block block) == true)
        {
            if (block.IsDestroyed == false)
            {
                CheckIfGoingHigher(block);
                block.SetProperties(false, true, false);
                List<CollectibleType> collectibleTypes = blockManager.PlacedOnCollectible(block);
                if (collectibleTypes.Contains(CollectibleType.FinishLine))
                {
                    return true;
                }
                foreach (CollectibleType collectibleType in collectibleTypes)
                {
                    if (collectibleType == CollectibleType.Bomb)
                    {
                        BombOpponent(player);
                    }
                }
            }
            block.Started -= BlockStarted;
        }
        return false;
    }

    private void CheckIfGoingHigher(Block block)
    {
        int currentHighest = highestCell;
        foreach (Cell cell in block.cells)
        {
            if (cell.ActuallPosition.y > currentHighest)
            {
                currentHighest = cell.ActuallPosition.y;
            }
        }
        if (currentHighest > highestCell)
        {
            highestCell = currentHighest;
            GoingHigher?.Invoke(highestCell);
        }
    }

    private void BlockStarted(Block block)
    {
        StartCoroutine(PeriodicalLower(block));
        block.StartMovement();
        block.Started -= BlockStarted;
    }

    private IEnumerator PeriodicalLower(Block block)
    {
        while (block.IsAlive)
        {
            while (Time.time < block.LastDown + lowerInterval)
            {
                yield return new WaitForSeconds(block.LastDown + lowerInterval - Time.time + 0.01f);
            }
            MoveOrderOutcome orderOutcome = blockManager.OrderMovement(block, Vector2Int.down);
            if (orderOutcome == MoveOrderOutcome.Collided_Dead)
            {
                RestartPlayer(block.PlayerColor);
                yield break;
            }
            else if (orderOutcome == MoveOrderOutcome.Collided_Hazard)
            {
                block.Destroy(destroyParticlesManager);
                RestartPlayer(block.PlayerColor);
                yield break;
            }
            else if (orderOutcome != MoveOrderOutcome.Moved)
            {
                yield return null;
            }
        }
    }

    private void EndGame(int sceneIndex, PlayerColor winners)
    {
        bool isLeft = multiplayerInitializer.IsLeft();
        StopPlayer(isLeft ? PlayerColor.Red : PlayerColor.Brown);
        StopPlayer(isLeft ? PlayerColor.Green : PlayerColor.Orange);
        StopPlayer(isLeft ? PlayerColor.Blue : PlayerColor.Purple);
        StopPlayer(isLeft ? PlayerColor.Yellow : PlayerColor.Teal);
        if (sceneIndex == multiplayerInitializer.SceneIndex)
        {
            StartCoroutine(WinCoroutine(winners));
        }
        else
        {
            StartCoroutine(LoseCoroutine());
        }
    }

    private IEnumerator WinCoroutine(PlayerColor winners)
    {
        float duration = 1;
        bool isLeft = multiplayerInitializer.IsLeft();
        while (duration > 0)
        {
            duration -= Time.deltaTime;
            duration = Mathf.Clamp(duration, 0, 1);
            float lerp = Mathf.Lerp(0.5f, 1, 1 - duration);
            camera.rect = new Rect(isLeft ? 0 : 1 - lerp, 0, lerp, 1);
            yield return null;
        }
        camera.rect = new Rect(0, 0, 1, 1);
    }

    private IEnumerator LoseCoroutine()
    {
        float duration = 1;
        bool isLeft = multiplayerInitializer.IsLeft();

        while (duration > 0)
        {
            duration -= Time.deltaTime;
            duration = Mathf.Clamp(duration, 0, 1);
            float lerp = Mathf.Lerp(0.5f, 0, 1 - duration);
            camera.rect = new Rect(isLeft ? 0 : 1 - lerp, 0, lerp, 1);
            yield return null;
        }
        camera.rect = new Rect(isLeft ? 0 : 1, 0, 0, 1);
        camera.gameObject.SetActive(false);
    }

    private void BombOpponent(PlayerColor player)
    {
        PlayerColor opponents = player.Opponents();
        multiplayerInitializer.InvokeBomb(opponents, bombDestroyCount);
    }











    private void OnLeft(PlayerColor playerColor)
    {
        if (activeBlocks.TryGetValue(playerColor, out Block block))
        {
            blockManager.OrderMovement(block, Vector2Int.left);
        }
    }

    private void OnRight(PlayerColor playerColor)
    {
        if (activeBlocks.TryGetValue(playerColor, out Block block))
        {
            blockManager.OrderMovement(block, Vector2Int.right);
        }
    }

    private void OnDown(PlayerColor playerColor)
    {
        if (activeBlocks.TryGetValue(playerColor, out Block block) == true && block.IsAlive == true)
        {
            MoveOrderOutcome moveOrderOutcome = blockManager.OrderMovement(block, Vector2Int.down);
            if (moveOrderOutcome == MoveOrderOutcome.Collided_Dead)
            {
                RestartPlayer(playerColor);
            }
            else if(moveOrderOutcome == MoveOrderOutcome.Collided_Hazard)
            {
                block.Destroy(destroyParticlesManager);
                RestartPlayer(block.PlayerColor);
            }
        }
    }

    private void OnRotateCounterClockwise(PlayerColor playerColor)
    {
        if (activeBlocks.TryGetValue(playerColor, out Block block))
        {
            blockManager.OrderRotation(block, false);
        }
    }

    private void OnRotateClockwise(PlayerColor playerColor)
    {
        if (activeBlocks.TryGetValue(playerColor, out Block block))
        {
            blockManager.OrderRotation(block, true);
        }
    }



}
