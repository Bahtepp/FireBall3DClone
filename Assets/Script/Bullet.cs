using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
       private float BulletSpeed = 7.0f;

    void Start()
    {
        
     
    }

    // Update is called once per frame
    void Update()
    { 
        BulletMovement();
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("towerblock"))
        {
            Destroy(other.gameObject);
            gameObject.SetActive(false);
            Destroy(gameObject,0.2f);
        }
    }
    void BulletMovement()
    {
        transform.Translate(Vector3.right * BulletSpeed * Time.deltaTime);
    
    }
        
}
