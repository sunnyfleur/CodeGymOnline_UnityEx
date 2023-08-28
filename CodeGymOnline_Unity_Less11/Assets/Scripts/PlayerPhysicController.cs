using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysicController : MonoBehaviour
{
    private static PlayerPhysicController instance;

    [SerializeField] public Collider2D playerCollider;
    [SerializeField] public Rigidbody2D playerRigidBody;
   

    public static PlayerPhysicController Instance { get => instance; }

    private void Reset()
    {
        LoadCollider();
        LoadRigidBody();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            PlayerController.Instance.isGrounded = true;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            PlayerController.Instance.isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            PlayerController.Instance.isGrounded = false;
        }
    }
    void LoadRigidBody()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }
    void LoadCollider()
    {
        playerCollider = GetComponent<Collider2D>();

    }
}

