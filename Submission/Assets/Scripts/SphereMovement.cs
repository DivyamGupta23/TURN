using UnityEngine;
using UnityEngine.UI;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    public float sphereSpeed = 0f;
    [SerializeField] private float maxY = 0f;
    public bool isMovingForward = false;
    [SerializeField] private SphereSO _sphereSO;
    [SerializeField] private Button _touchPanel;
    [SerializeField] private AudioSource _audioSource;

    private void Update()
    {

        if (transform.position.y <= maxY)
        {
            sphereSpeed = 0;
            speed = 0;
            GetComponent<PlayerManager>().GameOver();
        }
    }

    void Start()
    {
        _touchPanel.onClick.AddListener(ToggleMovement);
    }

    private void FixedUpdate()
    {
        speed = speed + (_sphereSO.score * 0.0001f);
        // Calculate the movement direction based on the current state
        Vector3 movementDirection = isMovingForward ? Vector3.forward : -Vector3.right;
        transform.Translate(movementDirection * sphereSpeed * Time.deltaTime);
    }
    public void ToggleMovement()
    {
        sphereSpeed = speed;
        isMovingForward = !isMovingForward; // Toggle the movement direction
        _audioSource.Play();
    }



}
