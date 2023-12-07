using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameTimer : MonoBehaviour
{
    public Text TimerText;
    private float timerTime = 20f;

    public float GetTimerTime
    {
        get { return timerTime; }
    }

    // Update is called once per frame
    void Update()
    {
        if (timerTime < 0)
        {
            TimerText.text = "0";
            timerTime = 0;
        }
        else
        {
            TimerText.text = $"{StringUtility.SecondsToTwoDecimalPlaces(timerTime -= Time.deltaTime)}";
        }
    }
}
