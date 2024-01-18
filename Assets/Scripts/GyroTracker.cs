using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroTracker : MonoBehaviour
{
    public Gyroscope gyro;

    public void OnEnable()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
        }
    }

    void OnGUI()
    {
        if (gyro == null)
        {
            return;
        }
        var style = new GUIStyle();
        style.fontSize = 80;
        GUILayout.Label($"Input.gyup.attitude{gyro.attitude}", style);
        GUILayout.Label($"Input.gyup.userAcceleration{gyro.userAcceleration}",style);
    }
}
