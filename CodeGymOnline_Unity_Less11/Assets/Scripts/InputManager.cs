using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;

    [SerializeField] private float inputHorizontal;
    [SerializeField] private float inputVertical;
    [SerializeField] private bool fire1;
    [SerializeField] private bool jump;

    public static InputManager Instance { get => instance; }
    public float InputVertical { get => inputVertical;  }
    public float InputHorizontal { get => inputHorizontal;  }
    public bool Fire1 { get => fire1;  }
    public bool Jump { get => jump;  }

    private void Start()
    {
        if (instance != null) return;
        instance = this;
    }
    private void Update()
    {
        CheckInput();
    }
    void CheckInput()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
        fire1 = Input.GetMouseButton(0);
       
        jump = Input.GetButtonDown("Jump");
    }

}
