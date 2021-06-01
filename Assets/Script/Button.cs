using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public AudioSource buttonPress;

    void Start()
    {
        Cursor.visible = true;
    }
    public void Back()
    {
        buttonPress.Play();
        SceneManager.LoadScene(1);
    }
    public void Stage1()
    {
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 3;
        SceneManager.LoadScene(2);
    }
    public void Stage2()
    {
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 4;
        SceneManager.LoadScene(2);
    }
    public void Stage3()
    {
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 5;
        SceneManager.LoadScene(2);
    }
    public void Stage4()
    {
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 6;
        SceneManager.LoadScene(2);
    }
}
