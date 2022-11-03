using UniRx;
using UnityEngine;

public class WallsRespawner : MonoBehaviour
{
    [SerializeField] private Transform _respawnPoint;
    [SerializeField] private Transform _newPoint;
    private readonly CompositeDisposable _disposable = new CompositeDisposable();

    private void CheckPosition()
    {
        if (transform.position.x <= _respawnPoint.position.x)
        {
            transform.position = _newPoint.position;
        }
    }

    private void Awake() => Observable.EveryUpdate()
        .Subscribe(_ => { CheckPosition(); })
        .AddTo(_disposable);

    private void OnDisable() => _disposable.Clear();
}