using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private GameObject targetObjectModel;
    [SerializeField] private float coordinateY;
    [SerializeField] private float coordinateX;
    [SerializeField] private float rotationSpeed=20f;

    private void Reset()
    {
        LoadRotationObject();
    }
    private void Start()
    {
        LoadRotationObject();
    }
    private void Update()
    {
        Rotate();
    }
    void LoadRotationObject()
    {
       

        this.targetObjectModel =GameObject.Find("Carrot1");
    }
    void Rotate()
    {
        Vector3 eulerAngle= new Vector3(0,1,0);
        this.targetObjectModel.transform.Rotate(eulerAngle * rotationSpeed * Time.deltaTime);
    }
}
