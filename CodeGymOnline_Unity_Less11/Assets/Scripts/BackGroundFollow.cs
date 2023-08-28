using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundFollow : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [Range(0f, 10f)]
    [SerializeField] private float followSpeed = 0.1f;

    private void LateUpdate()
    {
        FollowObject();
    }
    void FollowObject()
    {
        transform.position = Vector2.Lerp(this.transform.position, targetObject.transform.position, followSpeed * Time.deltaTime);
    }
}
