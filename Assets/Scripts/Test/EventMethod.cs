using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMethod : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Start���O��1�񂾂����s�����");
    }
    private void Start()
    {
        Debug.Log("Awake���S�ď������ꂽ���1�񂾂����s�����");
    }
    private void Update()
    {
        Debug.Log("���t���[�����s�����B�������ACPU�̑��x�ɂ���ăt���[���͕ϓ����܂�");
    }
    private void FixedUpdate()
    {
        Debug.Log("��莞�ԊԊu���ƂɌĂяo�����B���������Ȃǂ𑀍삷�鎞�Ɏg���B");
    }
    private void LateUpdate()
    {
        Debug.Log("Update�̌�ɌĂяo����B�J�����̑���̎��ȂǂɎg���B");
    }
    private void OnEnable()
    {
        Debug.Log("����GameObject��Active���I���ɂȂ������Ɏ��s�����B" +
        "Awake����AStart���O�Ɏ��s����܂��B");
    }
    private void OnDisable()
    {
        Debug.Log("����GameObject��Active���I�t�ɂȂ������Ɏ��s�����B");
    }
}