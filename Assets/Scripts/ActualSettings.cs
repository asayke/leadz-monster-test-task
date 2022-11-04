using UnityEngine;

public class ActualSettings : MonoBehaviour
{
    private Settings _settings;

    public Settings Settings => _settings;

    private void ChangeSettings(Settings settings) => _settings = settings;

    private void OnEnable()
    {
        SettingsButtonsScripts.OnSettingsChanged += ChangeSettings;
        EndGameChangeSettings.OnSettingsChangedEndGame += ChangeSettings;
    }

    private void OnDisable()
    {
        SettingsButtonsScripts.OnSettingsChanged -= ChangeSettings;
        EndGameChangeSettings.OnSettingsChangedEndGame -= ChangeSettings;
    }

    private void Start() => DontDestroyOnLoad(this);
}