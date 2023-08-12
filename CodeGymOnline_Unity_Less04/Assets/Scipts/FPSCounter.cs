using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    private float deltaTime;

    private void Update()
    {
       float fps=1/Time.deltaTime;
        Debug.Log(fps);
    }
    private void FixedUpdate()
    {
       // xu li vat li
    }
}
