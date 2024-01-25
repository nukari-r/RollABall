using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class SwipeDetection : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler

{
	// スワイプの許容時間
	public float duration = 0.25f;

	// スワイプとして認識されるのに必要となるドラッグの最低距離
	public float threshold = 200;

	// 左右のスワイプに対する反応をトリガーするイベント
	public UnityEvent onSwipeRight;
	public UnityEvent onSwipeLeft;

	// ドラッグの開始時間を保持
	public float startTime;

	// ドラッグの開始位置と終了位置の差
	public Vector2 delta;

	public void OnBeginDrag(PointerEventData eventData)
	{
		// クリックした時間を初期化
		startTime = Time.time;

		// 運動の変化量deltaを初期化
		delta = new Vector2();
	}

	public void OnDrag(PointerEventData eventData)
	{
		// 運動の変化量deltaを更新 
		delta += eventData.delta;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		if ((Time.time - startTime) > duration)
		{
			return;
		}

		if (Mathf.Abs(delta.x) > threshold)
		{
			if (delta.x > 0)
			{
				onSwipeRight?.Invoke();
			}
			else
			{
				onSwipeLeft?.Invoke();
			}
		}
	}
}
