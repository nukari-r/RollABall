using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; internal set; }

    public string playerName;

    public int PlayerAge;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else if (Instance != this)
        {
            Destroy(this);
        }
    }

    public UnityEvent nameUpdate;

    public string PlayerName
    {
        set
        {
            playerName = value;
            nameUpdate?.Invoke();

        }

    }

}
