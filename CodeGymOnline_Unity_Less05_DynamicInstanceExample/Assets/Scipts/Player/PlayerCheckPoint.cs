using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckPoint : MonoBehaviour
{
    [SerializeField] protected int checkPoint=0;

    private void Start()
    {
        ResetCheckPointOnStart();
    }

    void ResetCheckPointOnStart()
    {
        this.checkPoint = 0;
    }
    void LogCheckPoint()
    {
        Debug.Log("Check Point Reached: " + checkPoint);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CheckPoint")
        {
            checkPoint += 1;
            LogCheckPoint();
        }
    }
}
