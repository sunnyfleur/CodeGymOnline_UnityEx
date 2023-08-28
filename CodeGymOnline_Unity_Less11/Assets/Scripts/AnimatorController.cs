using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private static AnimatorController instance;
    [SerializeField] Animator playerAnimator;
    

    public static AnimatorController Instance { get => instance; }

    private void Start()
    {
        if (instance != null) return;
        instance = this;
        LoadAnimator();
        LoadSpriteRenderer();
    }
    void LoadAnimator()
    {
        playerAnimator = GetComponent<Animator>();
    }
    private void Update()
    {
        CheckState();
    }
    void CheckState()
    {
        playerAnimator.SetBool("isRunning", PlayerController.Instance.isRunning);
        playerAnimator.SetBool("isAttack", PlayerController.Instance.isAttacking);
        playerAnimator.SetBool("isJump", PlayerController.Instance.isJumping);
        playerAnimator.SetBool("isGrounded", PlayerController.Instance.isGrounded);
        playerAnimator.SetBool("isRunning", PlayerController.Instance.isRunning);
    }

    public SpriteRenderer LoadSpriteRenderer()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        return spriteRenderer;
    }

}
