using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : Singleton<Receiver>
{
    [SerializeField] protected int damaged=0;
    [SerializeField] protected int maxDamaged = 100;
    [SerializeField] protected int fuel = 50;
    [SerializeField] protected int capacity = 100;

    public void RenewHealthPoint()
    {
        this.damaged = 0;
    }
    public void IncreaseDamaged(int damage)
    {
        this.damaged += damage;
    }
    public void AddFuelPoint(int add)
    {
        this.fuel += add;
        if (this.fuel >= capacity)
            this.fuel = capacity;
    }

}
