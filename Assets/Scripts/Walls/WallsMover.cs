using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class WallsMover : MonoBehaviour, IMovable
{
    [SerializeField] private float _speedIncrease;
    private ActualSettings _actualSettings;
    private Rigidbody2D _wallsRigidbody2D;
    private float _speed;
    public event Action<float> OnSpeedChanged;

    public void Move() => _wallsRigidbody2D.velocity = Vector2.left * _speed;

    private IEnumerator Moving()
    {
        while (true)
        {
            Move();
            yield return new WaitForSeconds(15f);
            _speed += _speedIncrease;
            OnSpeedChanged?.Invoke(_speed);
        }
    }

    private void Awake()
    {
        _actualSettings = FindObjectOfType<ActualSettings>();
        _wallsRigidbody2D = GetComponent<Rigidbody2D>();
        _speed = _actualSettings.Settings.BallSpeed;
    }

    private void Start() => StartCoroutine(Moving());
}