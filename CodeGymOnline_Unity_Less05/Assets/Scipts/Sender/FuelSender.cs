using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelSender : Singleton<FuelSender>
{
    [SerializeField] protected int fuelContainer = 10;

    public void SendFuel()
    {
        Receiver.Instance.AddFuelPoint(fuelContainer);
    }
}
