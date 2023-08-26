using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCalculation : Singleton<SpeedCalculation>
{
    public float deltaPosition = 0f;
    public Rigidbody rigidBody;
    public Vector3 lastPosition;
    public float time;
    public Vector3 displacement;
    public float speed;

    private void Start()
    {
        LoadRigidBody();
        this.lastPosition = rigidBody.position;
    }
    private void Reset()
    {
        LoadRigidBody();
    }
    private void FixedUpdate()
    {
        SpeedCalculate();
    }
    void LoadRigidBody()
    {
        if (this.rigidBody != null) return;
        this.rigidBody = GetComponent<Rigidbody>();
    }
    void SpeedCalculate()
    {
        float lastTimestamp = Time.time;
        time = Time.deltaTime;
        Vector3 displacement = rigidBody.position - lastPosition;
        deltaPosition = displacement.magnitude;
        if (Mathf.Approximately((deltaPosition), 0f))
        {
            deltaPosition = 0f;
        }
        speed= deltaPosition/ Time.deltaTime;   

        lastPosition = rigidBody.position;
        float lastTime=Time.time;


    }

}
