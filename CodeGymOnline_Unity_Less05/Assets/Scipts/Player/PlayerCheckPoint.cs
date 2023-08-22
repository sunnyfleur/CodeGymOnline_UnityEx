using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckPoint : Singleton<PlayerCheckPoint>
{
    [SerializeField] private int checkPoint = 0;

    public int CheckPoint { get => checkPoint; }

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
        Debug.Log("Check Point Reached: " + CheckPoint);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CheckPoint")
        {
            checkPoint += 1;
            Score.Instance.currentScore = CheckPoint;    
        }
    }
}
