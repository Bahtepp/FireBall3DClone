using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovingBlocks : MonoBehaviour
{
    public float speed = 3.0f; // Hız
    public float distance = 10.0f; // Hareket aralığı
    private Vector3 startPos;
    private bool movingForward = true;

    void Start()
    {
    
        startPos = transform.position;
    }

    void Update()
    {
       BlockerMovement();
       
    }
    void OnTriggerEnter (Collider other){
        Destroy(other.gameObject);
    }
    void BlockerMovement(){
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