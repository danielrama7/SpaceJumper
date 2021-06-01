using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageLock : MonoBehaviour
{
    public GameObject LockStage2;
    public GameObject LockStage3;
    public GameObject LockStage4;
    public int Stage;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Stage = PlayerPrefs.GetInt("StageLock");

        if (Stage == 4)
        {
            LockStage2.SetActive(false);
        }
        if (Stage == 5)
        {
            LockStage3.SetActive(false);
        }
        if (Stage == 6)
        {
            LockStage4.SetActive(false);
        }
    }
}
