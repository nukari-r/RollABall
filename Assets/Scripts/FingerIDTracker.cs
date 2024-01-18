using System;
using UnityEngine;
using UnityEngine.Events;

public class FingerIDTracker : MonoBehaviour
{
    public int trackedFingerID;

    [Serializable]
    public class Vector3UnityEvent : UnityEvent<Vector3> { };

    public Vector3UnityEvent touchDetected;

    private void Update()
    {
        int touchCount = Input.touchCount;
        for (int i = 0; i < touchCount; i++)
        {
            if (Input.GetTouch(i).fingerId == trackedFingerID)
            {
                touchDetected.Invoke(Input.GetTouch(i).position);
            }
        }
    }
}
