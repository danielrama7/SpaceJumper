using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gas : MonoBehaviour
{
    public AudioSource collectSound;
    public int theSeconds;

    void OnTriggerEnter()
    {
        Timer.gas += 20;
        collectSound.Play();
        Destroy(gameObject);
    }
}
