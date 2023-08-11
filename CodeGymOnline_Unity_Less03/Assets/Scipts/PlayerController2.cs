using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum PlayerDirection
{
    Up, Down, Left, Right, NotMoving
}
public class PlayerController2 : MonoBehaviour
{
    [SerializeField] protected PlayerDirection currentDirection=PlayerDirection.NotMoving;

    [Range(0f, 30f)]
    [SerializeField] protected float objectSpeed = 10f;

    [Header("Action")]
    [SerializeField] protected bool isMovingFoward = false;
    [SerializeField] protected bool isMovingBackward = false;
    [SerializeField] protected bool isRotating = false;

    void Start()
    {

    }
    void Update()
    {
        CheckDirection();
        RotateObject();
        MoveObject();
    }

    public void CheckDirection()
    {
        if (InputManager.Instance.PlayerCurrentInput == PlayerInput.keyUp)
        {
            isMovingFoward=true;
            this.currentDirection = PlayerDirection.Up;
        }
          
        if (InputManager.Instance.PlayerCurrentInput == PlayerInput.keyDown)
        {
            isMovingBackward = false;
            this.currentDirection = PlayerDirection.Up;
        }  
        if (InputManager.Instance.PlayerCurrentInput == PlayerInput.keyLeft)
        {
            isRotating = true;
            this.currentDirection = PlayerDirection.Left;
        }
        if (InputManager.Instance.PlayerCurrentInput == PlayerInput.keyRight)
        {
            isRotating = true;
            this.currentDirection = PlayerDirection.Right;
        }
        else
        {
          
        }

    }
    public void RotateObject()
    {
        float rotateRightAngle = 4f;
        float rotateLeftAngle = -4f;
        Vector3 currentAngle = transform.parent.eulerAngles;
        if (currentDirection == PlayerDirection.Left && this.isRotating == true)
        {
            transform.parent.eulerAngles = currentAngle + new Vector3(0f, rotateLeftAngle, 0f);
            this.isRotating = false;
        }
        if (currentDirection == PlayerDirection.Right && this.isRotating == true)
        {
            transform.parent.eulerAngles = currentAngle + new Vector3(0f, rotateRightAngle, 0f);
            this.isRotating = false;
        }
    }

    public void MoveObject()
    {
        if (isMovingFoward == true)
        {
            Vector3 movement = transform.forward  * objectSpeed * Time.deltaTime;
            this.transform.parent.position += movement;
        }
        else if (isMovingBackward == true)
        {
            Vector3 movement = transform.forward * objectSpeed * Time.deltaTime;
            this.transform.parent.position -= movement;
        }
    }
}
