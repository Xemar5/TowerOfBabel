using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using System.Collections.Generic;

public class MultiplayerInitializer : MonoBehaviour
{
    [SerializeField]
    private new Camera camera = null;
    [SerializeField]
    private PlayerManager playerManager = null;
    [SerializeField]
    private GameObject[] rootObjects;

    private int sceneIndex = -1;
    private static int nextIndex = 0;
    private static int randomSeed = -1;

    public int SceneIndex => sceneIndex;
    public System.Random random { get; set; }
    public System.Random blockRandom { get; set; }
    public int RandomSeed
    {
        get
        {
            if (randomSeed == -1)
            {
                randomSeed = UnityEngine.Random.Range(0, int.MaxValue / 4) * 2;
            }
            else
            {
                randomSeed += 1;
            }
            return randomSeed / 2;
        }
    }

    public event Action OnInitialized;
    public static event Action<int, PlayerColor, int> OnBomb;
    public static event Action<int, PlayerColor> OnEnd;


    private void Awake()
    {
        sceneIndex = GetSceneIndex();
        random = new System.Random();
        blockRandom = new System.Random(RandomSeed);

        bool isLeft = IsLeft();
        camera.rect = isLeft ? new Rect(0, 0, 0.5f, 1) : new Rect(0.5f, 0, 0.5f, 1);
        playerManager.SetPlayers(isLeft ? PlayerColor.Red.Team() : PlayerColor.Brown.Team());
        foreach (GameObject rootObject in rootObjects)
        {
            if (isLeft == true)
            {
                rootObject.transform.position += Vector3.left * 100;
            }
            else
            {
                rootObject.transform.position += Vector3.right * 100;
            }
        }
    }

    private void Start()
    {
        OnInitialized?.Invoke();
    }

    public void InvokeBomb(PlayerColor opponents, int bombDestroyCount)
    {
        OnBomb?.Invoke(sceneIndex, opponents, bombDestroyCount);
    }
    public void InvokeEnd(PlayerColor opponents)
    {
        OnEnd?.Invoke(sceneIndex, opponents);
    }

    public bool IsLeft()
    {
        if (sceneIndex % 2 == 0) return true;
        if (sceneIndex % 2 == 1) return false;
        throw new System.Exception("Invalid scene index");
    }

    private int GetSceneIndex()
    {
        if (sceneIndex == -1)
        {
            return nextIndex++;
        }
        else
        {
            return sceneIndex;
        }
    }

}


public static class RandomExtenstion
{
    public static int Range(this System.Random random, int min, int max)
    {
        return random.Next(min, max);
    }
    public static float Range(this System.Random random, float min, float max)
    {
        return (float)random.NextDouble() * (max - min) + min;
    }
}