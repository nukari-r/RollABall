using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventPublisher : MonoBehaviour
{
    ///リアクションを引き起こすイベント
    public UnityEvent Published;

    /// イベントをトリガーするメソッド
    public void Publish()
    {
        Published?.Invoke();

        // 上記と同じ意味です
        //if (Published != null)
        //{
        //    Published.Invoke();
        //}
    }

}
