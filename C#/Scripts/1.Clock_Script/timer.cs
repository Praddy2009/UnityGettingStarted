using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class timer : MonoBehaviour
{

    string hour,min,sec;
    public TextMeshProUGUI text;
    // Update is called once per frame
    void Update()
    {
        timetell();
    }

    public void timetell(){
        DateTime tim= DateTime.Now;
        hour=tim.Hour.ToString();
        min=tim.Minute.ToString();
        sec=tim.Second.ToString();
        text.text=hour+":"+min+":"+sec; 
    }
}
