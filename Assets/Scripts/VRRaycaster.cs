using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VRRaycaster : MonoBehaviour
{
	[Tooltip("The layers considered as valid targets")]
	public LayerMask layerMasks;

	[Tooltip("maximum detection distance")]
	public float distance;

	[Tooltip("Game object currently being hit")]
	private GameObject hitGameObject;

	[System.Serializable]
	public class GameObjectUnityEvent :
	UnityEvent<GameObject>
	{ }

	[Tooltip("Event when hovering a target passed as argument")]
	public GameObjectUnityEvent hitTarget;

	[System.Serializable]
	public class Vector3UnityEvent : UnityEvent<Vector3> { }

	[Tooltip("Information relative to a hit 3D properties")]
	public Vector3UnityEvent hitPosition, hitAngle;

	[Tooltip("Event sent when no longer over a target")]
	public UnityEvent stopHittingTarget;

	public void Raycast()
	{
		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit hitInfo;
		bool hasHit =
		Physics.Raycast(ray, out hitInfo, distance, layerMasks);

		// ���������ꍇ���������ΏۂɊ֘A����C�x���g���X�V
		if (hasHit)
		{
			if (hitGameObject != hitInfo.transform.gameObject)
			{
				hitTarget?.Invoke(hitGameObject);
				// �����ǉ����Ă�������
				// ���������Q�[���I�u�W�F�N�g�̖��O���o���܂�
				Debug.Log(hitInfo.transform.gameObject.name);
			}
			hitAngle?.Invoke(hitInfo.normal);
			hitPosition?.Invoke(hitInfo.point);
		}
		else if (hitGameObject)
		{
			// hoveredObject = null;
			stopHittingTarget?.Invoke();
		}
	}

    private void Update()
    {
		Raycast();
	}

}
