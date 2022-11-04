using UnityEngine;
using UnityEngine.EventSystems;
using UniRx;

public class UpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private readonly CompositeDisposable _disposable = new CompositeDisposable();
    private BallMover _ballMover;

    private void Enable() => Observable.EveryUpdate()
        .Subscribe(_ => { _ballMover.Move(); })
        .AddTo(_disposable);

    private void Disable() => _disposable.Clear();

    private void Start() => _ballMover = FindObjectOfType<BallMover>();

    public void OnPointerDown(PointerEventData eventData) => Enable();

    public void OnPointerUp(PointerEventData eventData) => Disable();
}