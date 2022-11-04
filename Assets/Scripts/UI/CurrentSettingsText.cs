using TMPro;
using UnityEngine;

public class CurrentSettingsText : MonoBehaviour
{
    private TextMeshProUGUI _text;

    private void ResetText(Settings settings) => _text.SetText($"Current settings : {settings.SettingsTitle}");

    private void OnEnable() => SettingsButtonsScripts.OnSettingsChanged += ResetText;

    private void OnDisable() => SettingsButtonsScripts.OnSettingsChanged -= ResetText;

    private void Awake() => _text = GetComponent<TextMeshProUGUI>();

    private void Start() => _text.SetText($"Current settings : Easy");
}