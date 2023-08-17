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
    [SerializeField] protected GameObject automaticController;
    [SerializeField] protected GameObject physicController;

   
    [SerializeField] public DriveMode driveMode;
    [SerializeField] public bool isOverDamaged=false;



   
  
    

    void Start()
    {
        LoadController();
    }
    private void Reset()
    {
        LoadController();
    }
    private void Update()
    {   
        CheckState(manualController,automaticController);
        CheckCondition();
    }
    public void LoadController()
    {
        LoadAutomaticControl();
        LoadManualControl();
        LoadPlayerPhysicController();

    }
    public void LoadManualControl()
    {
        if (this.manualController != null) return;
        else
            this.manualController = GameObject.Find("PlayerManualController");
    }


    public void LoadAutomaticControl()
    {
        if (this.automaticController != null) return;
        else
            this.automaticController = GameObject.Find("PlayerAutomaticController");
    }
    public void LoadPlayerPhysicController()
    {
        if(this.physicController != null) return;
        this.physicController = GameObject.Find("PlayerPhysicController");
    }
    public void CheckState(GameObject manualControl, GameObject automaticControl)
    {
        if(this.driveMode== DriveMode.ManualControl)
        {
            automaticControl.SetActive(false);
            manualControl.SetActive(true);
            physicController.SetActive(false);
        }
        else if(this.driveMode == DriveMode.AutomaticControl)
        {
            manualControl.SetActive(false);
            automaticControl.SetActive(true);
            physicController.SetActive(false);
        }
        else if(this.driveMode==DriveMode.PhysicControl)
        {
            manualControl.SetActive(false);
            automaticControl.SetActive(false) ;
            physicController.SetActive(true) ;
        }
        else
        {
            manualControl.SetActive(false);
            automaticControl.SetActive(false);
            physicController.SetActive(true);
        }
    }


    private void CheckCondition()
    {
        if (!isOverDamaged) return;

       
    }
}
