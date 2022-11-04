using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameButtonsScripts : MonoBehaviour
{
    [SerializeField] private GameObject _otherUI;
    [SerializeField] private GameObject _settings;

    public void ReloadGame() => SceneManager.LoadScene("GameScene");

    public void OpenSettings()
    {
        _otherUI.SetActive(false);
        _settings.SetActive(true);
    }

    public void CloseSettings()
    {
        _otherUI.SetActive(true);
        _settings.SetActive(false);
    }
}