using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class WallsMover : MonoBehaviour, IMovable
{
    //ПОЛУЧАТЬ ИЗ НАСТРОЕК
    private float _wallsSpeed = 50f;
    private Rigidbody2D _wallsRigidbody2D;

    public void Move() => _wallsRigidbody2D.velocity = Vector2.left * _wallsSpeed;

    private void Awake()
    {
        _wallsRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start() => Move();
}