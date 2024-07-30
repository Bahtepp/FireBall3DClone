using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
    
    public TowerManager walkBool;
    
    private float BulletSpeed = 7.0f;
    private float xBound = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
       walkBool = GameObject.Find("TowerManager").GetComponent<TowerManager>();
    }

    // Update is called once per frame
    void Update()
    { 
        BulletMovement();
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("towerblock")){
        Destroy(gameObject);
        Destroy(other.gameObject);
       
        }
    }
    void BulletMovement(){
        transform.Translate(Vector3.right * BulletSpeed * Time.deltaTime);
        if(!walkBool.walk){
            if (transform.position.x>xBound){
            Destroy(gameObject);
            }
            
        }
        
    }
        
}
