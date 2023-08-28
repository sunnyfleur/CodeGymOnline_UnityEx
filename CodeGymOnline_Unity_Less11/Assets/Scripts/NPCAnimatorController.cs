using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAnimatorController : MonoBehaviour
{
    private static NPCAnimatorController instance;

    [SerializeField] private SpriteRenderer playerSpriteRenderer;
    [SerializeField] private Animator NPCAnimator;

    public static NPCAnimatorController Instance { get => instance;  }

    private void Start()
    {
        if (instance != null) return;
        instance = this;
    }
    void CheckState()
    {
        NPCAnimator.SetBool("isAttack", NPCMovement.Instance.IsAttacking);
        NPCAnimator.SetBool("isWalk", NPCMovement.Instance.IsMoving);
    }
    private void Update()
    {
        CheckState();
    }
    public SpriteRenderer LoadSpriteRenderer()
    {
        SpriteRenderer NPCSpriteRenderer = GetComponent<SpriteRenderer>();
        return NPCSpriteRenderer;
    }

}
