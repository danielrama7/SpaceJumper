using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject timeDisplay;
    public bool isTakingTime = false;
    public int theSeconds = 150;

    // Update is called once per frame
    void Update()
    {
        if(isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());

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
}
