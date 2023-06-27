using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonFunctions : MonoBehaviour
{
    [SerializeField] SphereSO sphereSO;
    [SerializeField] TextMeshProUGUI highScoreText;
    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    public void About()
    {
        Application.OpenURL("https://github.com/DivyamGupta23");
    }
    public void MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
    void Start()
    {
        highScoreText.text = "HighScore : " + sphereSO.highScore;
    }

}
