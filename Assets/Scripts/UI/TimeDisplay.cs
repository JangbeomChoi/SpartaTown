using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    public Text timeText;

    private void Start()
    {
        
        UpdateTimeDisplay();
    }

    private void Update()
    {
        
        UpdateTimeDisplay();
    }

    private void UpdateTimeDisplay()
    {
        
        DateTime currentTime = DateTime.Now;
        string timeString = currentTime.ToString("HH:mm"); 
        timeText.text =  timeString;
    }
}
