using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImpact : MonoBehaviour
{    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Obstacle")
        {
            DamageSender.Instance.SendDamage();
        }
    }
}
