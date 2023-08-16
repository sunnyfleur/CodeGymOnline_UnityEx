using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    [SerializeField] protected int damage = 10;
    private static DamageSender instance;

    public static DamageSender Instance { get => instance; }

    private void Start()
    {
        if (instance != null) return;
        instance = this;
    }
   
    public void SendDamage()
    {
        Receiver.Instance.IncreaseDamaged(damage);
    }
    


}
