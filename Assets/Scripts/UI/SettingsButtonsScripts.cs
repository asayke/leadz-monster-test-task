using System;
using UnityEngine;

public class SettingsButtonsScripts : MonoBehaviour
{
    [SerializeField] private Settings _easySettings;
    [SerializeField] private Settings _middleSettings;
    [SerializeField] private Settings _hardSettings;
    public static event Action<Settings> OnSettingsChanged;

    private void Start() => SetEasy();

    public void SetEasy() => OnSettingsChanged?.Invoke(_easySettings);

    public void SetMiddle() => OnSettingsChanged?.Invoke(_middleSettings);

    public void SetHard() => OnSettingsChanged?.Invoke(_hardSettings);
}