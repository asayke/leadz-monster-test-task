using UnityEngine;

public class OpenDiedUI : MonoBehaviour
{
    [SerializeField] private GameObject _endGameUI;

    private void EnableUI() => _endGameUI.SetActive(true);

    private void OnEnable() => BallBorderCollision.OnDied += EnableUI;

    private void OnDisable() => BallBorderCollision.OnDied -= EnableUI;
}