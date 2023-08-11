using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerInput
{
    keyUp,
    keyDown,
    keyLeft,
    keyRight
}
public class InputManager : MonoBehaviour
{
    [SerializeField] private PlayerInput playerCurrentInput;
    private static InputManager instance;

    public static InputManager Instance { get => instance; }
    public PlayerInput PlayerCurrentInput { get => playerCurrentInput;  }

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

    public void CheckInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerCurrentInput = PlayerInput.keyUp;
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerCurrentInput = PlayerInput.keyDown;
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerCurrentInput = PlayerInput.keyLeft;
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerCurrentInput = PlayerInput.keyRight;
        }
        
    }

}
