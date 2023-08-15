using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Less04 : MonoBehaviour
{
    [SerializeField] protected Rigidbody body;
    float force = 10;

    public void LoadRigidBody()
    {
        body = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(Vector3.up*force, ForceMode.Impulse);
        }
        

        
    }

}
