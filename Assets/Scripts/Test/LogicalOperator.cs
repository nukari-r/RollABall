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
            Debug.Log("条件 1 と条件 2 は true です "); // false のため表示されない
        }
        if (condition1 || condition2) // true
        {
            Debug.Log("条件 1 または条件 2 が true です "); // true のため表示される
        }
    }

    void CheckCondition()
    {
        // &&:論理積（ AND
        Debug.Log(condition1 && condition2);
        // ||:論理和（ OR
        Debug.Log(condition1 || condition2);
        // !:否定（ NOT
        Debug.Log(!condition1);
        // ^:排他的論理和（ XOR
        Debug.Log(condition1 ^ condition2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
