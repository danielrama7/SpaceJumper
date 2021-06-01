using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;
    public GameObject levelBlocker;
    public GameObject fadeOut;
    public GameObject MoreItem;

    void OnTriggerEnter()
    {
        if(CollectItem.currentItem == 2)
        {
            GetComponent<BoxCollider>().enabled = false;
            levelBlocker.SetActive(true);
            levelBlocker.transform.parent = null;
            timeCalc = Timer.extendScore * 100;
            timeLeft.GetComponent<Text>().text = "Time Left: " + Timer.extendScore + "x 100";
            theScore.GetComponent<Text>().text = "Score: " + Score.currentScore;
            totalScored = Score.currentScore + timeCalc;
            totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
            PlayerPrefs.SetInt("LevelScore", totalScored);
            levelMusic.SetActive(false);
            levelTimer.SetActive(false);
            levelComplete.Play();
            StartCoroutine(CalculateScore());
        }
        else
        {
            StartCoroutine(CollectMoreItem());
        }
    }

    IEnumerator CalculateScore()
    {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(1);
        theScore.SetActive(true);
        yield return new WaitForSeconds(1);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        Score.currentScore = 0;
        CollectItem.currentItem = 0;
        SceneManager.LoadScene(RedirectToLevel.nextLevel);
        PlayerPrefs.SetInt("StageLock", RedirectToLevel.nextLevel);
    }
    IEnumerator CollectMoreItem()
    {
        MoreItem.SetActive(true);
        yield return new WaitForSeconds(2);
        MoreItem.SetActive(false);
    }
}
