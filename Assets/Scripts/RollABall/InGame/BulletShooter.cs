using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class BulletShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    private Rigidbody shooterRigidBody;

    private void Start()
    {
        shooterRigidBody
        = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Vector3 movingDirection = shooterRigidBody.velocity.normalized;
            var bulletInstance = Instantiate(bulletPrefab, transform.position + movingDirection * 1.5f, transform.rotation);
            var bulletRigidBody = bulletInstance.GetComponent<Rigidbody>();
            if (bulletRigidBody !=null)
            {
                bulletRigidBody.velocity
                = movingDirection * bulletSpeed;
            }
        }
    }

}
