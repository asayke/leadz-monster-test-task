using UnityEngine;

public class ObstacleRespawned : MonoBehaviour
{
    private Vector2 _minHeight = new Vector2(13f, -2.05f);
    private Vector2 _maxHeight = new Vector2(13f, 3f);

    private Vector2 MakeRandomHeight() => new Vector2(_minHeight.x, Random.Range(_minHeight.y, _maxHeight.y));

    private void OnEnable() => gameObject.transform.position = MakeRandomHeight();
}