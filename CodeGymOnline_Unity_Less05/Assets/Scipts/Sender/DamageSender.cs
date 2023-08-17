using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : Singleton<DamageSender>
{
    [SerializeField] protected int damage = 10;
   
    public void SendDamage()
    {
        Receiver.Instance.IncreaseDamaged(damage);
    }
    


}
