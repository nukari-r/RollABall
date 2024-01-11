using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityEventSubscliber : MonoBehaviour
{

    public UnityEventPublisher Publisher;
    public string debugMessage;

    private void OnEnable()
    {
        Publisher?.Published.AddListener(DebugResponce);
    }
    private void OnDisable()
    {
        Publisher?.Published.RemoveListener(DebugResponce);

    }

    public void DebugResponce()
    {
        Debug.Log("UnityEvent" + debugMessage);
    }
}
