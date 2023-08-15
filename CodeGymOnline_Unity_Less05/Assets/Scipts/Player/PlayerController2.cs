using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController2 : MonoBehaviour
{
   /*
    [SerializeField] protected Vector3 currentDirection;
    [SerializeField] protected CharacterController characterController;

    void Start()
    {
        LoadCharacterController();
    }
    private void Reset()
    {
        LoadCharacterController();
    }
    void Update()
    {       
        CheckDirection();       
        MoveObject();
    }

    protected void LoadCharacterController()
    {
        if (this.characterController != null) return;
        this.characterController=GetComponentInParent<CharacterController>();
    }
    protected void CheckDirection()
    {
        this.currentDirection = new Vector3(InputManager.Instance.InputVertical, 0, InputManager.Instance.InputHorizontal);
    }
    
    protected void RotateObject()
    {
        
    }
   

    protected override void MoveObject()
    {
        characterController.Move(currentDirection*objectSpeed*Time.deltaTime);
    }
     */
}
