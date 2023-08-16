using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSenderReference : MonoBehaviour
{
    [SerializeField] private DamageSender damageSender;
   

    public DamageSender DamageSender { get => damageSender; }

    private void Reset()
    {
        LoadDamageSender();
    }
    void LoadDamageSender()
    {
        if (this.DamageSender != null) return;

        damageSender=GetComponentInChildren<DamageSender>();
    }
}
