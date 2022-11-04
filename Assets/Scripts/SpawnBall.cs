using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] private GameObject _ballPrefab;
    [SerializeField] private Transform _spawnPoint;

    private void Start() => Instantiate(_ballPrefab, _spawnPoint.position, Quaternion.identity);
}