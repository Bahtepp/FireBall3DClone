using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;

public class MovingBlocks : MonoBehaviour
{
    public float speed = 0; // Hız
    public float distance = 10.0f; // Hareket aralığı
    private Vector3 startPos;
    private bool movingForward = true;
    
   

    void Start()
    {
        speed = Random.Range(3,10);
        startPos = transform.position;
    }

    void Update()
    {
       BlockerMovement();
       

    }
    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.CompareTag("bullet"))
        {
            Destroy(other.gameObject);
        }
        
    }
    void BlockerMovement()
    {
         if (movingForward)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if (Vector3.Distance(startPos, transform.position) >= 0.1f + distance)
            {
                movingForward = false;
            }
        }
        else
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            if (Vector3.Distance(startPos, transform.position) >= 0.1f + distance)
            {
                movingForward = true;
            }
        }
    }
    
    
}