using UnityEngine;
using UnityEngine.EventSystems;
using UniRx;

public class UpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, ISwitchingStates
{
    private readonly CompositeDisposable _disposable = new CompositeDisposable();
    private BallMover _ballMover;
    
    public void Enable() => Observable.EveryUpdate()
        .Subscribe(_ => { _ballMover.MoveVertical(); })
        .AddTo(_disposable);

    public void Disable() => _disposable.Clear();

    private void Awake() => _ballMover = FindObjectOfType<BallMover>();

    public void OnPointerDown(PointerEventData eventData) => Enable();

    public void OnPointerUp(PointerEventData eventData) => Disable();
}