using UniRx;
using UnityEngine;

public class LastAttempTime : MonoBehaviour
{
    private readonly CompositeDisposable _disposable = new CompositeDisposable();
    private float _gameTimer;

    public float GameTimer => _gameTimer;

    private void Awake() => Observable.EveryUpdate()
        .Subscribe(_ => { _gameTimer += Time.deltaTime; })
        .AddTo(_disposable);

    private void OnEnable() => BallBorderCollision.OnDied += _disposable.Clear;

    private void OnDisable() => BallBorderCollision.OnDied -= _disposable.Clear;
}