using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    [SerializeField] protected int damaged=0;
    [SerializeField] protected int maxDamaged = 100;
    [SerializeField] protected int fuel = 50;
    [SerializeField] protected int capacity = 100;

    private static Receiver instance;

    public static Receiver Instance { get => instance; }


    private void Start()
    {
        RenewHealthPoint();
        if (instance != null) return;

        instance = this;
       
    }
    public void RenewHealthPoint()
    {
        this.damaged = 0;
    }
    public void IncreaseDamaged(int damage)
    {
        this.damaged += damage;
        if(this.damaged >= maxDamaged) 
            GamePlayManager.Instance.isOverDamaged = true;
    }
    public void AddFuelPoint(int add)
    {
        this.fuel += add;
        if (this.fuel >= capacity)
            this.fuel = capacity;
    }

}
