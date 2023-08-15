using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class PlayerControllerAbstract : MonoBehaviour
{
    [Range(0f, 30f)]
    [SerializeField] protected float objectSpeed=10f;

    protected abstract void MoveObject();
   

}
