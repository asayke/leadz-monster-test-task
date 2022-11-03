using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FillObstaclesPool))]
public class ObstaclesPool : MonoBehaviour
{
    private readonly Stack<GameObject> _pool = new Stack<GameObject>();

    public void PushToPool(GameObject obstacle) => _pool.Push(obstacle);

    public void GetFromPool() => _pool.Pop();
}