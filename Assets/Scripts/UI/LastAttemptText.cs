using System;
using TMPro;
using UnityEngine;

public class LastAttemptText : MonoBehaviour
{
    private LastAttempTime _lastAttempTime;
    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
        _lastAttempTime = FindObjectOfType<LastAttempTime>();
    }

    private void OnEnable() => _text.SetText($"Last attempt time : {Math.Round(_lastAttempTime.GameTimer, 2)} seconds");
}