using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ForLoop();
        //ForeachLoop();
        //WhileLoop();
        //DoWhileLoop();


    }

    void DoWhileLoop()
    {
        int countor = 200;
        Debug.Log("1�`100�܂Ő����܂�");
        do
        {
            Debug.Log(countor);
            countor += 1;
        } while (countor <= 100);
        Debug.Log("�I�����܂�");
    }

    void WhileLoop()
    {
        Debug.Log("1�`100�܂Ő����܂�");
        int countor = 1;
        while (countor <= 100)
        {
            Debug.Log(countor);
            countor += 1;
        }
        Debug.Log("�I�����܂�");
    }

    void ForeachLoop()
    {
        int[] scores = { 50, 80, 60, 80, 90 };

        foreach (var score in scores)
        {
            Debug.Log(score);
        }
    }

    void ForLoop()
    {
        Debug.Log("1�`100�܂Ő����܂�");
        for (int countor = 1; countor <= 100; countor++)
        {
            Debug.Log(countor);
        }
        Debug.Log("�I�����܂�");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
