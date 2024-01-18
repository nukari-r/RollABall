using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RayCaster : MonoBehaviour
{
    public Camera usedCamera;

    private void OnEnable()
    {
        if (!usedCamera)
        {
            usedCamera = Camera.main;
        }
    }

    public void DrawRay(Vector3 clickPosition)
    {
        Ray ray = usedCamera.ScreenPointToRay(clickPosition);

        Debug.DrawRay(ray.origin, ray.direction);
    }


    public LayerMask layers;

    public float raycastDistance = 10.0f;

    [System.Serializable]
    public class StringUnityEvent : UnityEvent<string> { };

    public StringUnityEvent hitDetected;

    public void RayCast(Vector3 clickPosition)
    {
        RaycastHit hit;
        Ray ray = usedCamera.ScreenPointToRay(clickPosition);
        if (Physics.Raycast(ray, out hit, raycastDistance, layers))
        {
            Debug.Log(hit.transform.name);
            hitDetected.Invoke(hit.transform.name);
        }
    }

    private void Update()
    {
        RayCast(Input.mousePosition);
    }



}
