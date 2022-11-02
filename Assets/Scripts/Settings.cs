using UnityEngine;

[CreateAssetMenu(fileName = "Settings", menuName = "Settings")]
public class Settings : ScriptableObject
{
    [SerializeField] private float _ballSpeed;

    public float BallSpeed => _ballSpeed;
}