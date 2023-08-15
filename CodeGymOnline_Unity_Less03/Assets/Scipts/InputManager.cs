using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerInput
{
    none,
    keyUp,
    keyDown,
    keyLeft,
    keyRight
}
public class InputManager : MonoBehaviour
{
    [SerializeField] public PlayerInput playerCurrentInput;
    private static InputManager instance;

    public static InputManager Instance { get => instance; }
    public PlayerInput PlayerCurrentInput { get => playerCurrentInput; }

    private void Start()
    {
        if (instance != null)
            Debug.Log("Only 1 instance of InputManager allowed");
        else instance = this;
    }
    private void Update()
    {
     
        CheckInput();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
    public void CheckInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerCurrentInput = PlayerInput.keyUp;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            playerCurrentInput = PlayerInput.keyDown;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            playerCurrentInput = PlayerInput.keyLeft;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerCurrentInput = PlayerInput.keyRight;
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            GamePlayManager.Instance.CurrentGameState = DriveMode.ManualControl;
        }
            
        else if (Input.GetKeyDown(KeyCode.N))
        {
            GamePlayManager.Instance.CurrentGameState = DriveMode.AutomaticControl;
        }
           

        else
        {
            playerCurrentInput = PlayerInput.none;
        }

    }

}
