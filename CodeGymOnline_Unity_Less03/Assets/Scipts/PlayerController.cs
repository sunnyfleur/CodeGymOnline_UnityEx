using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    //Header
    [Header("vari")]
    //Set a range of choice
    [Range(10f, 19f)]
    [SerializeField] protected float speed = 10f;

    //Display in ...
    [ContextMenu("Menu")]
    private void MyContextMenu()
    {
        Debug.Log("lof");
    }
    [SerializeField] protected List<Vector3> checkPoints;
    [SerializeField] protected GameObject roadCorner;
    [SerializeField] protected int currentCheckPoint = 1;
    [SerializeField] protected float rotateSpeed = 30f;
    [SerializeField] protected Vector3 rotationAxis = Vector3.up;
    [SerializeField] protected float distance;
    [SerializeField] Vector3 current;

    [SerializeField] protected int time;
    public void Start()
    {
       
    }
    public void FixedUpdate()
    {
        MoveObject();
        Debug.Log(Time.time);
    }

    public void MoveObject()
    {
        this.current = checkPoints[this.CheckPosition()];
        transform.parent.position = Vector3.MoveTowards(transform.parent.position, current, speed * Time.deltaTime);
    }
    public void Reset()
    {
        LoadCheckPoints();
    }

    public void RotateObject()
    {

    }
    public int CheckPosition()
    {
        this.distance = (transform.parent.position - checkPoints[this.currentCheckPoint]).magnitude;
        if (distance < 0.1)
        {
            if (this.currentCheckPoint > 3)
            {
                this.currentCheckPoint = 0;
            }
            
            this.currentCheckPoint += 1;
            Rotate();
        }

        return this.currentCheckPoint;
    }

    public void Rotate()
    {
        Vector3 direction= current-transform.parent.position;
        Quaternion rotationAngle = Quaternion.LookRotation(direction, Vector3.up);
        transform.parent.rotation = rotationAngle;
    }
    public void LoadCheckPoints()
    {
        LoadRoadCorner();
        Transform[] Corners = roadCorner.GetComponentsInChildren<Transform>();

        foreach (Transform transform in Corners)
        {
            checkPoints.Add(transform.position);
        }
    }

    public void LoadRoadCorner()
    {
        if (roadCorner == null)
            this.roadCorner = GameObject.Find("RoadCorner");

        else Debug.Log("No road corner found");
    }
}
