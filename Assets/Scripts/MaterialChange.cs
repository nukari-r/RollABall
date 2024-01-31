using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;

public class MaterialChange : MonoBehaviour
{
    // Define the function template accepted by this event�@(���̃C�x���g�Ɏ󂯎����֐��e���v���[�g���`����)
    public ARFaceManager arFaceManager;

    //�������������}�e���A���̃��X�g 
    public List<Material> materials;

    //���ݑI������Ă���}�e���A���̃C���f�b�N�X
    private int index;

    //�����Ƃ��ĕ������n��Unity Event
    [System.Serializable]
    public class StringUnityEvent : UnityEvent<string> { }
    public StringUnityEvent materialUpdated;

    // ���̃}�e���A���ɕύX�A�Ō�܂ŗ����烋�[�v
    public void NextMaterial()
    {
        int nextIndex = index + 1;
        if (nextIndex >= materials.Count)
        {
            nextIndex = 0;
        }
        ChangeMaterial(nextIndex);
    }

    public void ChangeMaterial(int newMaterialIndex)
    {
        Material newMaterial = materials[newMaterialIndex];
        foreach (ARFace face in arFaceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = newMaterial;
        }

        index = newMaterialIndex;
        materialUpdated.Invoke(newMaterial.name);
    }

    public void Start()
    {
        ChangeMaterial(0);
    }

    public void OnEnable()
    {
        arFaceManager.facesChanged += FaceUpdated;
    }

    public void OnDisable()
    {
        arFaceManager.facesChanged -= FaceUpdated;
    }

    public void FaceUpdated(ARFacesChangedEventArgs args)
    {
        if (args.added.Count > 0)
        {
            ChangeMaterial(index);
        }
    }

}
