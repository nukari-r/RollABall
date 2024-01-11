using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTool : MonoBehaviour
{
    public void PrintPlayerAge()
    {
        Debug.Log(PlayerManager.Instance.PlayerAge);
    }
    public void PrintPlayerName()
    {
        Debug.Log(PlayerManager.Instance.playerName);
    }
    private void OnEnable()
    {
        PlayerManager.Instance.nameUpdate.AddListener(PrintPlayerName);
    }

    private void OnDisable()
    {
        PlayerManager.Instance.nameUpdate.RemoveListener(PrintPlayerName);
    }

}
