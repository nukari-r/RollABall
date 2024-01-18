using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerRaycast : MonoBehaviour
{
    /// <summary>
    /// ÉQÅ[ÉÄÉVÅ[Éìì‡Ç…Ç†ÇÈ
    /// </summary>
    public Camera usedCamera;

    private void OnEnable()
    {
        if (!usedCamera)
        {
            usedCamera = Camera.main;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Ray ray = usedCamera.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(ray.origin, ray.direction);
    }
}
