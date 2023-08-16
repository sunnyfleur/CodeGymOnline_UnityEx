using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] protected CharacterController characterController;
    [SerializeField] protected float speed=10f;
    // Start is called before the first frame update
    void Start()
    {
        characterController=GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        direction=transform.TransformDirection(direction);
        direction*=speed;

        if (characterController.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

            }
        }


        characterController.Move(direction*Time.deltaTime);
    }
}
