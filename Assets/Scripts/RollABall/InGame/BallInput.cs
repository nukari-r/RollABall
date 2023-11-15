using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallInput : MonoBehaviour
{
    public GameObject Ball;
    private Rigidbody ballRigidBody;

    private void Start()
    {
        ballRigidBody = Ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // WÉLÅ[Ç™âüÇ≥ÇÍë±ÇØÇƒÇ¢ÇÈä‘
        if (Keyboard.current.wKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.forward);
        }
        if (Keyboard.current.aKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.left);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.back);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            ballRigidBody.AddForce(Vector3.right);
        }
    }
}
