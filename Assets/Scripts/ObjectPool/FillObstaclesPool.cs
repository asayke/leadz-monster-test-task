using UnityEngine;

public class FillObstaclesPool : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;
    private ObstaclesPool _pool;

    private void Awake() => _pool = GetComponent<ObstaclesPool>();

    private void Start()
    {
        var obstacle = Instantiate(_obstaclePrefab, Vector2.zero, Quaternion.identity);
        for (int i = 0; i <= 10; i++)
            _pool.PushToPool(obstacle);
        Destroy(obstacle);
    }
}