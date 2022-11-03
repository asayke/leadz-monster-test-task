using UnityEngine;

public class FillObstaclesPool : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;
    [SerializeField] private int _poolSize;
    private ObstaclesPool _pool;

    private void Awake() => _pool = GetComponent<ObstaclesPool>();

    private void Start()
    {
        for (int i = 0; i <= _poolSize; i++)
        {
            var obstacle = Instantiate(_obstaclePrefab, Vector2.zero, Quaternion.identity);
            _pool.PushToPool(obstacle);
            obstacle.SetActive(false);
        }
    }
}