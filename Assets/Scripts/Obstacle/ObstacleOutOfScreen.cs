using UniRx;
using UnityEngine;

public class ObstacleOutOfScreen : MonoBehaviour
{
    private Vector2 _respawnPoint = Vector2(-15.25, 0);
    [SerializeField] private Transform _newPoint;
    private readonly CompositeDisposable _disposable = new CompositeDisposable();
    private ObstaclesPool _pool;

    private void CheckPosition()
    {
        if (transform.position.x < _respawnPoint.position.x)
        {
            gameObject.SetActive(false);
            _pool.PushToPool(gameObject);
        }
    }

    private void Awake()
    {
        _pool = FindObjectOfType<ObstaclesPool>();
        Observable.EveryUpdate()
            .Subscribe(_ => { CheckPosition(); })
            .AddTo(_disposable);
    }

    private void OnEnable() => gameObject.transform.position = _newPoint.position;

    private void OnDisable() => _disposable.Clear();
}