using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerWheelsController : MonoBehaviour
{
    [Header("Wheels")]
    [SerializeField] private WheelCollider frontLeftWheel;
    [SerializeField] private WheelCollider frontRightWheel;
    [SerializeField] private WheelCollider rearLeftWheel;
    [SerializeField] private WheelCollider rearRightWheel;

    [Range(0f, 90f)]
    [SerializeField] private float maxSteerAngle = 45f;
    [Range(0f, 3000f)]
    [SerializeField] private float motorForce = 1100f;
    [Range(0, 3000f)] private float brakeForce = 4000f;

    public Vector3 moveinput { get; private set; }

    private void Movement()
    {

        float force = motorForce * InputManager.Instance.InputVertical;
        float steerAngle = maxSteerAngle * InputManager.Instance.InputHorizontal;

        frontLeftWheel.steerAngle = steerAngle;
        frontRightWheel.steerAngle = steerAngle;

        rearLeftWheel.motorTorque = force;
        rearRightWheel.motorTorque = force;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            frontLeftWheel.brakeTorque = brakeForce;
            frontLeftWheel.brakeTorque = brakeForce;

            rearLeftWheel.brakeTorque = brakeForce;
            rearRightWheel.brakeTorque = brakeForce;
        }

        else
        {
            frontLeftWheel.brakeTorque = 0;
            frontLeftWheel.brakeTorque = 0;

            rearLeftWheel.brakeTorque = 0;
            rearRightWheel.brakeTorque = 0;
        }
    }

  


    private void Reset()
    {
      
    }

    private void Update()
    {
        Movement();
    }

}
