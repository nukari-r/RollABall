using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float destroyTime = 5f;
    
    void Update()
    {
        destroyTime -= Time.deltaTime;    
        // destroyTime = destroyTime - Time.deltaTime;
       
        if ( destroyTime < 0f)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject != null)
        {
            Destroy(this.gameObject);
        }
    }
}
