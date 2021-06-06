using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameObject timeDisplay;
    public bool isTakingTime = false;
    public int theSeconds = 100;
    public static int gas = 0;
    public static int extendScore;
    public GameObject TimesUp;
    public GameObject LevelBlocker;
    public GameObject fadeOut;

    // Update is called once per frame
    void Update()
    {
        extendScore = theSeconds;
        if(isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
            theSeconds += gas;
            gas = 0;
        }
        if(theSeconds == 0)
        {
            StartCoroutine(YourTimesUP());
            LevelBlocker.SetActive(true);
            LevelBlocker.transform.parent = null;
        }
    }

    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        theSeconds -= 1;
        timeDisplay.GetComponent<Text>().text = "" + theSeconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;

    }
    IEnumerator YourTimesUP()
    {
        TimesUp.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        Score.currentScore = 0;
        CollectItem.currentItem = 0;
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
    }
}