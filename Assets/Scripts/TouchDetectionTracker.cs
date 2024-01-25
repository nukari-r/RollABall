using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDetectionTracker : MonoBehaviour
{
    public int trackedTouchID;

    private void Update()
    {
        if (Input.touchCount > trackedTouchID)
        {
            transform.position = Input.GetTouch(trackedTouchID).position;
        }
    }

}
