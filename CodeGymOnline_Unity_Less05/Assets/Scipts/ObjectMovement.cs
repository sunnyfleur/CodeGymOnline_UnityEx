using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;

    private void Update()
    {
        MoveUpAndDown();
    }
    void MoveUpAndDown()
    {
        float time = Time.deltaTime;
        
    }
}
