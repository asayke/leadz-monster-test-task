using System;
using UnityEngine;

public class EndGameChangeSettings : MonoBehaviour
{
    [SerializeField] private Settings _easySettings;
    [SerializeField] private Settings _middleSettings;
    [SerializeField] private Settings _hardSettings;
    public static event Action<Settings> OnSettingsChangedEndGame;
    
    public void SetEasy() => OnSettingsChangedEndGame?.Invoke(_easySettings);

    public void SetMiddle() => OnSettingsChangedEndGame?.Invoke(_middleSettings);

    public void SetHard() => OnSettingsChangedEndGame?.Invoke(_hardSettings);
}