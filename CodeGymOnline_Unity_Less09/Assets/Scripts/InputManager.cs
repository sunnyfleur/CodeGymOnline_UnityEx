using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    [SerializeField] private float inputHorizontal;
    [SerializeField] private float inputVertical;
    [SerializeField] public bool inputJump;
    

    public static InputManager Instance { get => instance;  }
    public float InputHorizontal { get => inputHorizontal; }
    public float InputVertical { get => inputVertical; }
    public bool InputJump { get => inputJump;  }

    private void Start()
    {
        if (instance != null) return;
        instance = this;
    }
    private void Update()
    {
        CheckPlayerInput();
    }
    void CheckPlayerInput()
    {
        CheckMovement();
    }
 
    void CheckMovement()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");
        inputJump = Input.GetButtonDown("Jump");
    }
   
    
}
