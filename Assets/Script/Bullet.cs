using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float BulletSpeed = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * BulletSpeed * Time.deltaTime) ;
    }

     void OnTriggerEnter(Collider other)
    {
        // Eğer bullet bir engelle çarpışırsa
        if (other.CompareTag("Block"))
        {
            // Bullet objesini yok et
            Destroy(gameObject);
        }
}}
