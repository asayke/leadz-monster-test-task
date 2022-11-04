using TMPro;
using UnityEngine;

public class CurrentSettingsEndGame : MonoBehaviour
{
    private TextMeshProUGUI _text;
    private void ResetText(Settings settings) => _text.SetText($"Current settings : {settings.SettingsTitle}");
    
    private void Awake() => _text = GetComponent<TextMeshProUGUI>();
    
    private void OnEnable() => EndGameChangeSettings.OnSettingsChangedEndGame += ResetText;

    private void OnDisable() => EndGameChangeSettings.OnSettingsChangedEndGame -= ResetText;
}