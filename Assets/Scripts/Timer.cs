using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [Tooltip("�^�C�}�[���J�n���Ă���̎���"), SerializeField]
    private float elapsedTime;

    [Tooltip("�^�C�}�[�̎�������"), SerializeField]
    private float duration;

    [Tooltip("�p�[�Z���e�[�W�ŏo�͂���l"), SerializeField]
    private bool percentage;

    [System.Serializable]
    public class FloatUnityEvent : UnityEvent<float> { }

    [Tooltip("�p�[�Z���e�[�W�ŏ��������l"), SerializeField]
    public FloatUnityEvent elapsedTimeUpdated;

    [Tooltip("���Ԃ��؂��ƌĂяo�����"), SerializeField]
    public UnityEvent completed;

    // bool name  = true �p�[�Z���e�[�W�ɂ��l���f�t�H���g�ɐݒ�
    // GetProgress()�ƋL�q����̂�GetProgress(true)���Ӗ����܂�
    public float GetProgress(bool asPercentage = true)
    {
        // �ۑ����ꂽ�l
        float result;

        // �p�[�Z���e�[�W�A�܂��͌o�ߎ���
        if (asPercentage)
        {
            result = elapsedTime / duration;
        }
        else
        {
            result = elapsedTime;
        }

        // �ő�l���Ɏ��߂� 
        return Mathf.Clamp(result, 0, asPercentage ? 1 : duration);
    }

    public IEnumerator PerformTimeCheck()
    {
        // �������^�ł��������s
        while (elapsedTime < duration)
        {
            // �e���[�v���t���[���̏I���܂ő҂悤����
            yield return new WaitForEndOfFrame();
            // �o�ߎ��Ԃ��X�V 
            elapsedTime += Time.deltaTime;
            // ���X�i�[��elapsedTime���X�V���ꂽ���Ƃ�ʒm 
            elapsedTimeUpdated?.Invoke(GetProgress(percentage));  
        }
        // ���X�i�[�Ɏ��ԏI����ʒm
        completed?.Invoke();
    }

    // �^�C�}�[�������l�Ƀ��Z�b�g
    public void ResetTime()
    {
        // �o�ߎ��Ԃ��X�V 
        elapsedTime = 0;

        // ���X�i�[��elapsedTime���X�V���ꂽ���Ƃ�ʒm 
        elapsedTimeUpdated.Invoke(0);
    }
    public void StartTimer()
    {
        // ���s���ł���\���̂���R���[�`����S�ăL�����Z��
        StopAllCoroutines();

        // PerformTimeCheck�R���[�`�����J�n
        StartCoroutine(PerformTimeCheck());
    }
    public void RestartTimer()
    {
        // ���Ԃ�0�Ƀ��Z�b�g���A�T�u�X�N���C�o�ɒʒm
        ResetTime();

        // �^�C�}�[���J�n
        StartTimer();
    }

}