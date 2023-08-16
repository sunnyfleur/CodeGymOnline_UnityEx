using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelSender : MonoBehaviour
{
    [SerializeField] protected int fuelContainer = 10;

    private static FuelSender instance;

    public static FuelSender Instance { get => instance;  }

    private void Start()
    {
        if (instance != null) return;
        instance = this;
    }

    public void SendFuel()
    {
        Receiver.Instance.AddFuelPoint(fuelContainer);
    }
}
