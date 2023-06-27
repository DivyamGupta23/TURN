using UnityEngine;
using TMPro;
public class PlayerManager : MonoBehaviour
{
    [SerializeField] private SphereSO _sphereSO;
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _highScoreAlert;
    [SerializeField] private TextMeshProUGUI _highScoreText;
    [SerializeField] private GameObject _coinParticles;
    [SerializeField] private AudioSource _audioSourceCoin;

    [SerializeField] private GameObject gameOverObject;
    void Start()
    {
        _sphereSO.score = 0;
    }
    void Update()
    {
        if (_sphereSO.score > _sphereSO.highScore)
        {
            _sphereSO.highScore = _sphereSO.score;
            _highScoreAlert.gameObject.SetActive(true);
        }
        _scoreText.text = _sphereSO.score.ToString();
    }

    void OnTriggerEnter(Collider trigger)
    {
        if (trigger.CompareTag("SpawnTrigger"))
        {
            trigger.gameObject.transform.parent.GetComponent<SpawnPlatform>().Spawn();
        }
        if (trigger.CompareTag("ExitTrigger"))
        {
            trigger.gameObject.transform.parent.GetComponent<SpawnPlatform>().delayedDestroy();
        }

        if (trigger.CompareTag("Coin"))
        {
            _sphereSO.score += 1;
            Destroy(trigger.gameObject);
            _audioSourceCoin.Play();
            GameObject coinParticles = Instantiate(_coinParticles, trigger.gameObject.transform.position, Quaternion.identity);
            Destroy(coinParticles, 1f);
        }
    }
    public void GameOver()
    {
        // Debug.Log("Game Over");
        _highScoreText.text = "HighScore : " + _sphereSO.highScore;
        gameOverObject.SetActive(true);

    }


}
