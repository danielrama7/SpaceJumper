using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectItem : MonoBehaviour
{
    public GameObject fuelBox;
    public static int currentItem;
    public int internalItem;

    // Update is called once per frame
    void Update()
    {
        internalItem = currentItem;
        fuelBox.GetComponent<Text>().text = "" + internalItem;
    }
}

