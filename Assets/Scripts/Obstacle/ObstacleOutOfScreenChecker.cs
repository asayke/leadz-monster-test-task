using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class ObstacleOutOfScreenChecker : MonoBehaviour
{
    [SerializeField] private LayerMask _borderLayer;
    private readonly CompositeDisposable _disposable = new CompositeDisposable();
    private ObstaclesPool _pool;
    private BoxCollider2D _collider;

    private void Awake()
    {
        _collider = GetComponent<BoxCollider2D>();
        _pool = FindObjectOfType<ObstaclesPool>();

        _collider.OnTriggerEnter2DAsObservable().Where(other => other.gameObject.IsInLayerMask(_borderLayer))
            .Subscribe(
                obst =>
                {
                    obst.gameObject.SetActive(false);
                    _pool.PushToPool(obst.gameObject);
                }).AddTo(_disposable);
    }

    private void OnDisable() => _disposable.Clear();
}