using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class BallBorderCollision : MonoBehaviour
{
    [SerializeField] private LayerMask _borderLayer;
    private readonly CompositeDisposable _disposable = new CompositeDisposable();
    private CircleCollider2D _collider;

    private void Awake()
    {
        _collider = GetComponent<CircleCollider2D>();
        _collider.OnCollisionEnterAsObservable().Subscribe(_ =>
        {
            if (_.gameObject.IsInLayerMask(_borderLayer))
                Destroy(gameObject);
            _disposable.Clear();
        }).AddTo(_disposable);
    }
}