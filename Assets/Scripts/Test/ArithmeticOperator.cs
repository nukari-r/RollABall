using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArithmeticOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(1 + 2);   // 3
        Debug.Log(30 - 29); // 1
        Debug.Log(9 * 9);   // 81
        Debug.Log(120 / 5); // 24
        Debug.Log(120 / 7); // 17
        Debug.Log(120 % 7); // 1

        int sum = 5 + 13;
        Debug.Log(sum);     // 18
        sum = sum + 1;
        Debug.Log(sum);     // 19
        sum += 1;
        Debug.Log(sum);     // 20

        int number = 23; // 0から 51 までの任意の数
        string[] suits = { "ハート ", "ダイヤ ", "クラブ ", "スペード" };
        string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        string suit = suits[number / 13];
        string rank = ranks[number % 13];
        Debug.Log($"{suit} の {rank}"); // ダイヤの J
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
