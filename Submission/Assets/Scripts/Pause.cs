using UnityEngine;

public class Pause : MonoBehaviour
{
    public void pause()
    {
        Time.timeScale = 0;
    }
    public void unPause()
    {
        Time.timeScale = 1;
    }
}
