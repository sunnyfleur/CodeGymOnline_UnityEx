using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Animator characterAnimator;

    private void Update()
    {
        CheckState();
    }
    void CheckState()
    {
        characterAnimator.SetFloat("InputHorizontal", InputManager.Instance.InputHorizontal);
        characterAnimator.SetFloat("InputVertical",InputManager.Instance.InputVertical);
        characterAnimator.SetBool("IsJumping", InputManager.Instance.InputJump);
       
    }
}
