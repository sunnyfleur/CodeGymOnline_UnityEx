using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NPCMovement : MonoBehaviour
{
    private static NPCMovement instance;

    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private GameObject targetObject;
    [SerializeField] private float distanceToObject;

    [SerializeField] private float detectRange;
    [SerializeField] private float attackRange;
    [SerializeField] private Vector2 velocityToObject;

    [SerializeField] private bool isAttacking = false;
    [SerializeField] private bool isMoving = false;

    [SerializeField] private SpriteRenderer spriteRenderer;

    public static NPCMovement Instance { get => instance; }
    public bool IsAttacking { get => isAttacking; }
    public bool IsMoving { get => isMoving; }

    private void Start()
    {
        if (instance != null) return; instance = this;
        LoadSpriteRenderer();
    }
    private void Update()
    {
        DistanceCalculae();
        Move();
    }
    private void DistanceCalculae()
    {
        velocityToObject = transform.parent.position - targetObject.transform.position;
        distanceToObject =velocityToObject.magnitude;
        
    }
    private void Move()
    {
        if (distanceToObject < 10f && velocityToObject.x > 0)
        {
            MoveToObjectToTheRight();
        }
        else if (distanceToObject < 10f && velocityToObject.x < 0)
        {
            MoveToObjectToTheLeft();
        }
        if (distanceToObject < 5f)
        {
            Attack();
        }

        else
        {
            Idling();
        }
    }

    private void MoveToObjectToTheRight()
    {
        spriteRenderer.flipX = false;
        isMoving = true;
        transform.parent.position = Vector3.MoveTowards(transform.parent.position, targetObject.transform.position, moveSpeed * Time.deltaTime);
    }
    private void MoveToObjectToTheLeft()
    {
        spriteRenderer.flipX = true;
        isMoving = true;
        transform.parent.position = Vector3.MoveTowards(transform.parent.position, targetObject.transform.position, moveSpeed * Time.deltaTime);
    }
    private void Attack()
    {
        isAttacking = true;
    }
    private void Idling()
    {
        isAttacking = false;
        isMoving = false;
    }

    private void LoadSpriteRenderer()
    {
        this.spriteRenderer = NPCAnimatorController.Instance.LoadSpriteRenderer();
    }
}
