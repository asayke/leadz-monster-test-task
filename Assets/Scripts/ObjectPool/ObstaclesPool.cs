using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FillObstaclesPool))]
[RequireComponent(typeof(ObstaclesSpawner))]
public class ObstaclesPool : MonoBehaviour
{
    private readonly Stack<GameObject> _pool = new Stack<GameObject>();

    public void PushToPool(GameObject obstacle)
    {
        _pool.Push(obstacle);
        obstacle.SetActive(false);
    }

    public void GetFromPool()
    {
        var obstacle = _pool.Pop();
        obstacle.SetActive(true);
    }
}