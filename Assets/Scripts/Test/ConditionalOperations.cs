using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalOperations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IfStatement();
    }

    void IfStatement()
    {
        bool conditionTrue = true;
        bool conditionFalse = false;

        if (conditionTrue)
        {
            Debug.Log("true‚Ì‚½‚ß‚±‚Ìˆ—‚ªŒÄ‚Ño‚³‚ê‚Ü‚·");
        }
        if (conditionFalse)
        {
            Debug.Log("false‚Ì‚½‚ß‚±‚Ìˆ—‚ªŒÄ‚Ño‚³‚ê‚Ü‚¹‚ñ");
        }
    }
}
