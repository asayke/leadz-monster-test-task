using UnityEngine;

public class AttempsCounter : MonoBehaviour
{
    private int _count;

    public int Count => _count;

    private void Start()
    {
        if (PlayerPrefs.HasKey("AttempsCount"))
        {
            _count = PlayerPrefs.GetInt("AttempsCount");
            _count++;
            PlayerPrefs.SetInt("AttempsCount", _count);
        }
        else
        {
            _count++;
            PlayerPrefs.SetInt("AttempsCount", _count);
        }
    }
}