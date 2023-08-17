using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class Singleton<T>:MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    

    protected virtual void Awake() => Instance = this as T;
    protected virtual void OnApplication()
    {
        Instance = null;       
    }


    


    
}
