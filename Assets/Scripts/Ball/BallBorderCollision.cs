using System;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class BallBorderCollision : MonoBehaviour
{
    [SerializeField] private LayerMask _borderLayer;
    private readonly CompositeDisposable _disposable = new CompositeDisposable();
    private CircleCollider2D _collider;
    public static event Action OnDied;

    private void Awake()
    {
        _collider = GetComponent<CircleCollider2D>();
        _collider.OnCollisionEnter2DAsObservable().Where(other => other.gameObject.IsInLayerMask(_borderLayer))
            .Subscribe(
                _ =>
                {
                    print("sds");
                    OnDied?.Invoke();
                    _disposable.Clear();
                }).AddTo(_disposable);
    }
}