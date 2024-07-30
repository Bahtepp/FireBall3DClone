using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
    public bool walk = false;
    
    private float BulletSpeed = 7.0f;
    private float xBound = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x>xBound){
            Destroy(gameObject);
        }
        transform.Translate(Vector3.right * BulletSpeed * Time.deltaTime) ;
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("towerblock")){
        Destroy(gameObject);
        Destroy(other.gameObject);
       
        }}
        
}
