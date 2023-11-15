using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraInput : MonoBehaviour
{
    public float sensitivity = 0.01f;

    // Update is called once per frame
    void Update()
    {
        // 左クリックが押されている間
        if (Mouse.current.leftButton.isPressed)
        {
            // マウスの値を取得
            Vector2 delta = Mouse.current.delta.ReadValue();
            // CameraのTransformを動かす
            Camera.main.transform.Translate(new Vector3(delta.x, delta.y, 0) * sensitivity);
        }
    }
}
