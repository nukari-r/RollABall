using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMovement : MonoBehaviour
{
    // UIの現在の速さ
    public float speed = 100;

    // ゲームオブジェクトから取得した現在の向き
    public Vector3 currentDirection;

    // 指が画面上でドラッグされるたびに呼び出される関数
    public void MoveDirection(Vector2 moveValue)
    {
        // 位置を移動する
        currentDirection = moveValue;
    }

    public void Update()
    {
        // トランスフォームを現在の向きの方へ設定されたスピードで移動
        this.GetComponent<RectTransform>().anchoredPosition +=
            (Vector2)currentDirection * speed * Time.deltaTime;
    }

}
