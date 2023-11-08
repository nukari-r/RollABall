using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DotNet : MonoBehaviour
{
    public Text DayText;
    public Text DayAddWeekText;

    // Start is called before the first frame update
    void Start()
    {
        //ShowTime();
        DayText.text = DateTime.Now.ToString();
        DayAddWeekText.text = DateTime.Now.AddDays(7).ToString();
    }

    void ShowTime()
    {
        DateTime now = DateTime.Now;
        Debug.Log(now);
    }
}
