using TMPro;
using UnityEngine;

public class AttempsCounterText : MonoBehaviour
{
    private TextMeshProUGUI _text;
    private AttempsCounter _attemps;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
        _attemps = FindObjectOfType<AttempsCounter>();
    }

    private void OnEnable() => _text.SetText($"Attemps count : {_attemps.Count}");
}