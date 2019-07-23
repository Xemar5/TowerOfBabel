using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLineManager : MonoBehaviour
{
    [SerializeField]
    private new Camera camera = null;
    [SerializeField]
    private GameManager gameManager = null;
    [SerializeField]
    private BlockManager blockManager = null;

    private List<Transform> points = new List<Transform>();
    private Vector2Int spawnPosition;
    public Vector2Int SpawnPosition
    {
        get
        {
            UpdateSpawnX();
            return spawnPosition;
        }
    }

    private void Awake()
    {
        gameManager.GoingHigher += _ => UpdateSpawnX();
        SortPoints();
    }

    private void SortPoints()
    {
        foreach (Transform child in transform)
        {
            for (int i = 0; i < points.Count + 1; i++)
            {
                if (i == points.Count)
                {
                    points.Add(child);
                    break;
                }
                else if (child.position.y < points[i].position.y)
                {
                    points.Insert(i, child);
                    break;
                }
            }
        }
    }

    private void UpdateSpawnX()
    {
        Vector2 cameraTop = camera.ViewportToWorldPoint(new Vector3(0.5f, 1, camera.nearClipPlane));
        cameraTop.y += 1; // Move 1 cell above so it doesn't appear out of nowhere
        cameraTop.y = Mathf.Clamp(cameraTop.y, points[0].position.y, points[points.Count - 1].position.y);
        cameraTop.x = GetNearestPointX(cameraTop.y);

        Vector2Int topCellPosition = blockManager.GlobalToCellPosition(cameraTop);
        topCellPosition.y = Mathf.Min(blockManager.Height - 1, topCellPosition.y);
        spawnPosition = topCellPosition;
    }

    private float GetNearestPointX(float y)
    {
        if (y < points[0].position.y)
        {
            return points[0].position.x;
        }
        if (y >= points[points.Count - 1].position.y)
        {
            return points[points.Count - 1].position.x;
        }

        for (int i = 0; i < points.Count - 1; i++)
        {
            if (points[i + 1].position.y - points[i].position.y < 0.01f)
            {
                continue;
            }
            if (y >= points[i].position.y && y < points[i + 1].position.y)
            {
                float ratio = (y - points[i].position.y) / (points[i + 1].position.y - points[i].position.y);
                return Mathf.Lerp(points[i].position.x, points[i + 1].position.x, ratio);
            }
        }
        throw new Exception("Nearest point not found");
    }

    private void OnDrawGizmos()
    {
        Transform lastPoint = null;
        foreach (Transform child in transform)
        {
            Gizmos.DrawCube(child.position, Vector3.one / 2f);
            if (lastPoint != null)
            {
                Gizmos.DrawLine(lastPoint.position, child.position);
            }
            lastPoint = child;
        }
    }
}
