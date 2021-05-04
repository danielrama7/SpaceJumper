using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Star : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;
    
    void OnTriggerEnter()
    {
        Score.currentScore += 1000;
        collectSound.Play();
        Destroy(gameObject);
    }
}
