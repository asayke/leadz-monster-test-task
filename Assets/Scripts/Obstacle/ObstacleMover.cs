using UnityEngine;

public class ObstacleMover : MonoBehaviour, IMovable
{
    private Rigidbody2D _rigibody;

    //ПОЛУЧАТЬ ИЗ НАСТРОЕК
    private float _speed = 3f;

    public void Move() => _rigibody.velocity = Vector2.left * _speed;

    private void Awake()
    {
        _rigibody = GetComponent<Rigidbody2D>();
    }

    private void OnEnable() => Move();
}