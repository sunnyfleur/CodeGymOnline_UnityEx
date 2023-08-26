using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject targetObject;
    [SerializeField] private Vector3 offset = new Vector3(7, 2, 3);
    [SerializeField] private float followSpeed;

    private void LateUpdate()
    {
        Follow();
    }
    void Follow()
    {
        mainCamera.transform.position = targetObject.transform.position + offset;
        transform.LookAt(targetObject.transform);     
    }
    private void Reset()
    {
        LoadCamera();
        LoadTargetObject();
    }
    void LoadCamera()
    {
        mainCamera = GetComponent<Camera>();
    }
    void LoadTargetObject()
    {
        targetObject = GameObject.Find("Character");
    }


}
