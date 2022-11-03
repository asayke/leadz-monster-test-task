using System.Collections;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    [SerializeField] private float _spawnOffset;
    private ObstaclesPool _pool;
    private WaitForSeconds _seconds;

    private IEnumerator SpawnObstacles()
    {
        while (true)
        {
            yield return _seconds;
            _pool.GetFromPool();
        }
    }

    private void Awake()
    {
        _pool = GetComponent<ObstaclesPool>();
        _seconds = new WaitForSeconds(_spawnOffset);
    }

    private void Start() => StartCoroutine(SpawnObstacles());
}