using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ChangeIdleWalkingState : MonoBehaviour
{
    private Animator remyAnimator;
    
    void Start()
    {
        this.remyAnimator = this.transform.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame) {

            this.remyAnimator.SetTrigger("ChangeIdleWalkingState");
        }
    }
}
