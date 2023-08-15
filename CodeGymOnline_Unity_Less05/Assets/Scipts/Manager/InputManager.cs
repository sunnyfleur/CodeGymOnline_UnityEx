using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class InputManager : MonoBehaviour
{
    [SerializeField] protected float inputHorizontal;
    [SerializeField] protected float inputVertical;
    [SerializeField] protected float inputRotation;
    [SerializeField] protected bool isBraking;

    private static InputManager instance;

    public static InputManager Instance { get => instance; }
    public float InputHorizontal { get => inputHorizontal; }
    public float InputVertical { get => inputVertical; }
    public float InputRotation { get => inputRotation;  }
    public bool IsBraking { get => isBraking;  }

    private void Start()
    {
        if (instance != null)
            Debug.Log("Only 1 instance of InputManager allowed");
        else instance = this;
    }
    private void Update()
    {
        CheckMovementInput();
        CheckSystemInput();
    }
    public void CheckMovementInput()
    {
        this.inputHorizontal = Input.GetAxisRaw("Horizontal");
        this.inputVertical = Input.GetAxisRaw("Vertical");
        
    }
    public void CheckBreaking()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;

        else this.isBraking = true;
    }
    public void CheckSystemInput()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            GamePlayManager.Instance.CurrentGameState = DriveMode.ManualControl;
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            GamePlayManager.Instance.CurrentGameState = DriveMode.AutomaticControl;
        }
        else if(Input.GetKeyDown(KeyCode.B))
        {
            GamePlayManager.Instance.CurrentGameState = DriveMode.PhysicControl;
        }
    }

}
