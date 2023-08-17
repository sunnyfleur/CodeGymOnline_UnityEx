using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] protected Transform targetObject;
    [SerializeField] protected float followSpeed = 3f;
    [SerializeField] protected Vector3 offset = new Vector3(3f, 5f, 7f);
   
    void Start()
    {
        LoadPlayerObject();
    }
    private void Reset()
    {
        LoadPlayerObject();
    }
    public void LoadPlayerObject()
    {
        if (targetObject != null) return;
        else
            this.targetObject = GameObject.Find("Player").transform;    
    }

    void LateUpdate()
    {
        FollowOject();
    }

    public void FollowOject()
    {
        Vector3 desiredPosition= targetObject.position+offset;
        Vector3 smoothedPosition = Vector3.Lerp(desiredPosition, offset, followSpeed*Time.deltaTime);
        transform.parent.position = smoothedPosition;
        transform.parent.LookAt(targetObject.position);
    }
}
