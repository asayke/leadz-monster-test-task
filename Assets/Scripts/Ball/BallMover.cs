using UnityEngine;

public class BallMover : MonoBehaviour
{
    private Rigidbody2D _ballRigibody;

    //temp-speed
    private float _speed = 5f;

    private void Awake() => _ballRigibody = GetComponent<Rigidbody2D>();
    public void MoveVertical() => _ballRigibody.velocity = _speed * Vector2.up;
}