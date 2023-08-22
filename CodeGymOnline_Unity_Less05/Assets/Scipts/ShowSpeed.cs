using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowSpeed : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI speedTextBox;

    void LoadSpeedTextBox()
    {
        if (speedTextBox != null) return;
        speedTextBox=GetComponentInChildren<TextMeshProUGUI>();
    }
    private void Reset()
    {
        LoadSpeedTextBox(); 
    }
    private void LateUpdate()
    {
        UpdateSpeed();
    }
    private void Start()
    {
        LoadSpeedTextBox();
    }
    void UpdateSpeed()
    {
        this.speedTextBox.text = Convert.ToString(SpeedCalculation.Instance.deltaPosition*1000);
    }
}
