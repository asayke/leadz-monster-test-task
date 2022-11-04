using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    private WallsMover _walls;
    private Rigidbody2D _rigibody;
    private float _speed;

    private void Move(float speed)
    {
        _speed = speed;
        _rigibody.velocity = Vector2.left * speed;
    }

    private void Awake()
    {
        _walls = FindObjectOfType<WallsMover>();
        _speed = _walls.Speed;
        _rigibody = GetComponent<Rigidbody2D>();
        _walls.OnSpeedChanged += Move;
    }

    private void OnEnable() => Move(_speed);
}