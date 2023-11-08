using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMethod : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Startより前に1回だけ実行される");
    }
    private void Start()
    {
        Debug.Log("Awakeが全て処理された後に1回だけ実行される");
    }
    private void Update()
    {
        Debug.Log("毎フレーム実行される。ただし、CPUの速度によってフレームは変動します");
    }
    private void FixedUpdate()
    {
        Debug.Log("一定時間間隔ごとに呼び出される。物理挙動などを操作する時に使う。");
    }
    private void LateUpdate()
    {
        Debug.Log("Updateの後に呼び出され。カメラの操作の時などに使う。");
    }
    private void OnEnable()
    {
        Debug.Log("このGameObjectのActiveがオンになった時に実行される。" +
        "Awakeより後、Startより前に実行されます。");
    }
    private void OnDisable()
    {
        Debug.Log("このGameObjectのActiveがオフになった時に実行される。");
    }
}
