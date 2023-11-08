using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    int[] testScores = new int[5];
    List<int> testNum = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        testScores[0] = 85;
        testScores[1] = 90;
        testScores[2] = 78;
        testScores[3] = 88;
        testScores[4] = 76;

        Debug.Log(testScores[1]);

        testNum.Add(1);
        testNum.Add(2);
        testNum.Add(3);

        Debug.Log(testNum[0]);

        testNum.Remove(2);

        Debug.Log(testNum.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
