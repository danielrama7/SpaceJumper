using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;
    public int bestScore;
    public int Stage2;
    public GameObject bestScoreDisplay;

    void Start()
    {
        Cursor.visible = true;
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreDisplay.GetComponent<Text>().text = "BEST: " + bestScore;
    }

    public void PlayGame()
    {
        buttonPress.Play();
        SceneManager.LoadScene(9);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayCreds()
    {
        buttonPress.Play();
        SceneManager.LoadScene(7);
    }
    
    public void ResetBest()
    {
        PlayerPrefs.SetInt("LevelScore", 0);
    }

    public void HowToPlay()
    {
        buttonPress.Play();
        SceneManager.LoadScene(8);
    }

    public void Settings()
    {
        buttonPress.Play();
        SceneManager.LoadScene(10);
    }

    public void Back()
    {
        buttonPress.Play();
        SceneManager.LoadScene(1);
    }
}
