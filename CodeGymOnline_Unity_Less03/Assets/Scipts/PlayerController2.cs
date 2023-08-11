using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum PlayerDirection
{
    Up, Down, Left, Right, NotMoving
}
public class PlayerController2 : PlayerControllerAbstract
{
    [SerializeField] protected PlayerDirection currentDirection = PlayerDirection.NotMoving;
   
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

    protected void CheckDirection()
    {
        if (InputManager.Instance.playerCurrentInput == PlayerInput.keyUp)
        {
            isMovingFoward = true;
            this.currentDirection = PlayerDirection.Up;
        }

        else if (InputManager.Instance.playerCurrentInput == PlayerInput.keyDown)
        {
            isMovingBackward = true;
            this.currentDirection = PlayerDirection.Down;
        }
        else if (InputManager.Instance.playerCurrentInput == PlayerInput.keyLeft)
        {
            isRotating = true;
            this.currentDirection = PlayerDirection.Left;
        }
        else if (InputManager.Instance.playerCurrentInput == PlayerInput.keyRight)
        {
            isRotating = true;
            this.currentDirection = PlayerDirection.Right;
        }
        else
        {
            isMovingFoward = false;
            isRotating = false;
            this.currentDirection = PlayerDirection.NotMoving;
        }

    }
    protected void RotateObject()
    {
        float rotateRightAngle = 1f;
        float rotateLeftAngle = -1f;
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

    protected override void MoveObject()
    {
        if (this.currentDirection == PlayerDirection.Up)
        {
            Vector3 movement = transform.forward * objectSpeed * Time.deltaTime;
            this.transform.parent.position += movement;
        }
        else if (this.currentDirection == PlayerDirection.Down)
        {
            Vector3 movement = transform.forward * objectSpeed * Time.deltaTime;
            this.transform.parent.position -= movement;
        }
    }
}
