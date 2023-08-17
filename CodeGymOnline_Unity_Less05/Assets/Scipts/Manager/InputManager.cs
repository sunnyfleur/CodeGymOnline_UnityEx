using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class InputManager : Singleton<InputManager>
{
    [SerializeField] protected float inputHorizontal;
    [SerializeField] protected float inputVertical;

    public float InputHorizontal { get => inputHorizontal; }
    public float InputVertical { get => inputVertical; }

    private void Update()
    {
        CheckMovementInput();
        CheckSystemInput();
    }
    public void CheckMovementInput()
    {
        this.inputHorizontal = Input.GetAxis("Horizontal");
        this.inputVertical = Input.GetAxis("Vertical");  
    }
    public void CheckSystemInput()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            GamePlayManager.Instance.currentDriveMode = DriveMode.ManualControl;
        }
    }

}
