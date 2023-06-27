using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public Toggle pauseToggle;
    public AudioSource audioSource;
    private bool musicON;
    private void Start()
    {
        pauseToggle.onValueChanged.AddListener(OnToggleValueChanged);
    }

    private void OnToggleValueChanged(bool value)
    {
        musicON = value;

        if (musicON)
        {
            // Pause the audio source
            audioSource.UnPause();
        }
        else
        {
            // Unpause the audio source
            audioSource.Pause();
        }
    }
}
