using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class InputManager : Singleton<InputManager>
{
    [SerializeField] protected float inputHorizontal;
    [SerializeField] protected float inputVertical;
    [SerializeField] protected float inputRotation;
    [SerializeField] protected bool isBraking;

   
   


    public float InputHorizontal { get => inputHorizontal; }
    public float InputVertical { get => inputVertical; }
    public float InputRotation { get => inputRotation;  }
    public bool IsBraking { get => isBraking;  }

    private void Start()
    {
       
    }
    protected override void Awake()
    {
        base.Awake();

    }
    protected override void OnApplication()
    {
        base.OnApplication();
    }



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
    public void CheckBraking()
    {        
        if (Input.GetKeyDown(KeyCode.Space)==true)
        {
            this.isBraking = true;
        }      
        else { this.isBraking = false; }
    }
    public void CheckSystemInput()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            GamePlayManager.Instance.CurrentDriveMode = DriveMode.ManualControl;
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            GamePlayManager.Instance.CurrentDriveMode = DriveMode.AutomaticControl;
        }
        else if(Input.GetKeyDown(KeyCode.B))
        {
            GamePlayManager.Instance.CurrentDriveMode = DriveMode.PhysicControl;
        }
    }

}
