using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fuel : MonoBehaviour
{
    public GameObject fuelBox;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        CollectItem.currentItem += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
