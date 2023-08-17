using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController3 : PlayerControllerAbstract
{
    [SerializeField] protected Rigidbody rigidBody;
    [SerializeField] protected GameObject targetObject;


    [SerializeField] protected float rotationSpeed = 40f;
    [SerializeField] protected Vector3 moveDirection;
    [SerializeField] protected float brakeForce = 10f;
   


    private void Start()
    {
        LoadComponent();
    }
    private void Reset()
    {
        LoadComponent();
    }

    protected void LoadComponent()
    {
        LoadGameObject();
        LoadRigidBody();
    }
    private void Update()
    {
        this.MoveObject();
        this.RotateObject();
        this.CheckBraking();
    }
    public void LoadGameObject()
    {
        if (this.targetObject != null) return;
        this.targetObject = GameObject.Find("Player");
    }
    public void LoadRigidBody()
    {
        if (rigidBody != null) return;
        this.rigidBody=targetObject.GetComponent<Rigidbody>();
    }
    protected override void MoveObject()
    {
        moveDirection = new Vector3(InputManager.Instance.InputHorizontal, 0, InputManager.Instance.InputVertical);
        transform.TransformDirection(moveDirection);
        rigidBody.AddForce(moveDirection,ForceMode.Force);
    }
    protected void CheckBraking()
    {
        if (InputManager.Instance.IsBraking==true)
        {
            Vector3 brakeForceVector = -rigidBody.velocity.normalized * this.brakeForce;
            rigidBody.AddForce(brakeForceVector, ForceMode.Force);
        }
      
    }
    protected void RotateObject()
    {       
        Quaternion rotation = Quaternion.Euler(0,InputManager.Instance.InputHorizontal* this.rotationSpeed * Time.deltaTime, 0);
        rigidBody.MoveRotation(rigidBody.rotation * rotation);
    }
}
