using UnityEngine;

[CreateAssetMenu(fileName = "Settings", menuName = "Settings")]
public class Settings : ScriptableObject
{
    [SerializeField] private float _ballSpeed;
    [SerializeField] private string _settingsTitle;

    public float BallSpeed => _ballSpeed;
    public string SettingsTitle => _settingsTitle;
}