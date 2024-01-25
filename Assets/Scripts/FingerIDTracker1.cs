using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerIDTracker1 : MonoBehaviour
{
    public int fingerID;

    private void Update()
    {
        int touchCount = Input.touchCount;

        for (int i = 0; i < touchCount; i++)
        {
            if (Input.GetTouch(i).fingerId == fingerID)
            {
                transform.position = Input.GetTouch(i).position;
            }
        }
    }

}
