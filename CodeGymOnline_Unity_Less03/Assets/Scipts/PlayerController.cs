using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public enum TargetEnum
{
    TopLeft, TopRight, BottomLeft, BottomRight
}
public class PlayerController : PlayerControllerAbstract
{
    [SerializeField] protected Transform topLeftTarget;
    [SerializeField] protected Transform topRightTarget;
    [SerializeField] protected Transform bottomLeftTarget;
    [SerializeField] protected Transform bottomRightTarget;

    [SerializeField] private Transform currentTarget;
    [SerializeField] private TargetEnum nextTarget = TargetEnum.TopLeft; // Gán tr?ng thái ??u tiên là TopLeft

    // Start is called before the first frame update
    void Start()
    {
        currentTarget = topLeftTarget;
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject();
    }

    protected override void MoveObject()
    {
        Vector3 targetPosition = currentTarget.position;
        Vector3 moveDirection = targetPosition - transform.position;

        float distance = moveDirection.magnitude;

        if (distance > 0.1f)
        {
            // Khi ch?a t?i thì v?n di chuy?n v? ?i?m focus
            transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, objectSpeed * Time.deltaTime);
        }
        else
        {
            // Chuy?n target
            SetNextTarget(nextTarget);
        }

        // Thay ??i góc quay theo h??ng target object
        Vector3 direction = currentTarget.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = targetRotation;
    }

    private void SetNextTarget(TargetEnum target)
    {
        switch (target)
        {
            case TargetEnum.TopLeft:
                currentTarget = topLeftTarget;
                nextTarget = TargetEnum.TopRight;
                break;
            case TargetEnum.TopRight:
                currentTarget = topRightTarget;
                nextTarget = TargetEnum.BottomLeft;
                break;
            case TargetEnum.BottomLeft:
                currentTarget = bottomLeftTarget;
                nextTarget = TargetEnum.BottomRight;
                break;
            case TargetEnum.BottomRight:
                currentTarget = bottomRightTarget;
                nextTarget = TargetEnum.TopLeft;
                break;
        }
    }
}
