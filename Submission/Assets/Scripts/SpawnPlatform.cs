using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject[] _platforms;

    public void Spawn()
    {
        GameObject spawnnedPlatform = Instantiate(_platforms[Random.Range(0, _platforms.Length)], _spawnPoint.position, Quaternion.identity);
    }
    public void delayedDestroy()
    {
        Destroy(gameObject, 2.5f);
    }

}
