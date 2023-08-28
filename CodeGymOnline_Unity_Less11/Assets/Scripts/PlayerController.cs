using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private static PlayerController instance;

    [Range(0f, 30f)]
    [SerializeField] private float movingSpeed = 2f;
    [SerializeField] private float jumpForce = 160f;
    [SerializeField] private Vector3 direction;
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private Collider2D collider2D;

    [SerializeField] private SpriteRenderer playerSpriteRenderer;
    [SerializeField] public bool isGrounded = false;
    [SerializeField] public bool isJumping = false;
    [SerializeField] public bool isAttacking = false;
    [SerializeField] public bool isRunning = false;

    public float MovingSpeed { get => movingSpeed; }
    public Vector3 Direction { get => direction; }
    public static PlayerController Instance { get => instance; }

    private void Start()
    {
        if (instance != null) return;
        instance = this;

    }
    private void Update()
    {
        PlayerMovement();
    }

    private void Reset()
    {
        LoadSpriteRenderer();
    }

    void PlayerMovement()
    {
        if (InputManager.Instance.InputHorizontal > 0)
            PlayerMovingForward();
        else if (InputManager.Instance.InputHorizontal < 0)
            PlayerMovingBackward();
        else if (InputManager.Instance.Fire1)
            PlayerAttack();
        else if (InputManager.Instance.Jump)
            PlayerJump();
        else
            PlayerIdling();
    }


    void PlayerMovingForward()
    {
        isRunning = true;
        direction = Vector3.right;
        playerSpriteRenderer.flipX = false;
        transform.parent.Translate(Direction * MovingSpeed * Time.deltaTime);
 
    }

    void PlayerMovingBackward()
    {
        isRunning = true;
        direction = Vector3.left;
        playerSpriteRenderer.flipX = true;
        transform.parent.Translate(Direction * MovingSpeed * Time.deltaTime);
    }

    void PlayerIdling()
    {
        isRunning = false;
        isJumping = false;
        isAttacking = false;
    }

    void PlayerAttack()
    {
        isAttacking = true;

    }
    void PlayerJump()
    {
        isJumping = true;
        if (InputManager.Instance.Jump && isGrounded)
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpForce);
        }
   
    }

    private void LoadSpriteRenderer()
    {
        playerSpriteRenderer = AnimatorController.Instance.LoadSpriteRenderer();
    }

}
