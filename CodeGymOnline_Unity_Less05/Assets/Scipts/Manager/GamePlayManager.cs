using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DriveMode
{
    AutomaticControl,
    ManualControl,
    PhysicControl,
    None
}
public class GamePlayManager : MonoBehaviour
{
    private static GamePlayManager instance;
    [SerializeField] protected GameObject manualController;
    [SerializeField] protected GameObject automaticController;
    [SerializeField] protected GameObject physicController;
    [SerializeField] private DriveMode currentGameState;

    public static GamePlayManager Instance { get => instance; }
    public DriveMode CurrentGameState { get => currentGameState; set => currentGameState = value; }

    void Start()
    {
        if (instance != null)
            Debug.Log("Only one GameManager instance allowed");
        else instance = this;

        LoadController();
    }
    private void Reset()
    {
        LoadController();
    }
    private void Update()
    {   
        CheckState(manualController,automaticController);
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
        if(this.currentGameState== DriveMode.ManualControl)
        {
            automaticControl.SetActive(false);
            manualControl.SetActive(true);
            physicController.SetActive(false);
        }
        else if(this.currentGameState == DriveMode.AutomaticControl)
        {
            manualControl.SetActive(false);
            automaticControl.SetActive(true);
            physicController.SetActive(false);
        }
        else if(this.currentGameState==DriveMode.PhysicControl)
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

}
