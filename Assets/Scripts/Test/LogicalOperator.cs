using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperator : MonoBehaviour
{
    bool condition1 = true;
    bool condition2 = false;

    // Start is called before the first frame update
    void Start()
    {
        //CheckCondition();
        if (condition1 && condition2) // false
        {
            Debug.Log("���� 1 �Ə��� 2 �� true �ł� "); // false �̂��ߕ\������Ȃ�
        }
        if (condition1 || condition2) // true
        {
            Debug.Log("���� 1 �܂��͏��� 2 �� true �ł� "); // true �̂��ߕ\�������
        }
    }

    void CheckCondition()
    {
        // &&:�_���ρi AND
        Debug.Log(condition1 && condition2);
        // ||:�_���a�i OR
        Debug.Log(condition1 || condition2);
        // !:�ے�i NOT
        Debug.Log(!condition1);
        // ^:�r���I�_���a�i XOR
        Debug.Log(condition1 ^ condition2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}