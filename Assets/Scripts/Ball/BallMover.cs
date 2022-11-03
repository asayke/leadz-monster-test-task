using UnityEngine;

public class BallMover : MonoBehaviour, IMovable
{
    [SerializeField] private float _speed;
    private Rigidbody2D _ballRigibody;

    private void Awake() => _ballRigibody = GetComponent<Rigidbody2D>();
    public void Move() => _ballRigibody.velocity = _speed * Vector2.up;
}