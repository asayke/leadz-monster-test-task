using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScripts : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _settings;

    public void Quit() => Application.Quit();

    public void Play() => SceneManager.LoadScene("GameScene");

    public void OpenSettings()
    {
        _menu.SetActive(false);
        _settings.SetActive(true);
    }

    public void CloseSettings()
    {
        _menu.SetActive(true);
        _settings.SetActive(false);
    }
}