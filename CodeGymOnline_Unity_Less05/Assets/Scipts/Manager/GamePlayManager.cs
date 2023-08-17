using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum DriveMode
{
    AutomaticControl,
    ManualControl,
    PhysicControl,
    None
}
public class GamePlayManager : Singleton<GamePlayManager>
{
    [SerializeField] protected GameObject manualController;
    [SerializeField] public DriveMode currentDriveMode;
   
    void Start()
    {
        LoadController();
    }
    private void Reset()
    {
        LoadController();
    }
    public void LoadController()
    {    
        LoadManualControl();
    }
    public void LoadManualControl()
    {
        if (this.manualController != null) return;
        else
            this.manualController = GameObject.Find("PlayerManualController");
    }
    public void CheckState(DriveMode newDriveMode)
    {
        currentDriveMode = newDriveMode;

        if (newDriveMode == DriveMode.None) return;

        if(newDriveMode == DriveMode.ManualControl)
        {
            manualController.gameObject.SetActive(true);
            currentDriveMode = DriveMode.ManualControl;
        }
          

    }
}
