using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
    
    public TowerManager walkBool;
    public TowerManager destroyList;
    private float BulletSpeed = 7.0f;
    private float xBound = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        destroyList = GameObject.Find("TowerMmanager").GetComponent<TowerManager>();
     walkBool = GameObject.Find("TowerMmanager").GetComponent<TowerManager>();
    }

    // Update is called once per frame
    void Update()
    { 
        BulletMovement();
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("towerblock")){
            Destroy(other.gameObject);
            gameObject.SetActive(false);
            Destroy(gameObject,0.2f);
            destroyList.towerBlocks.RemoveAt(0);
            destroyList.howMuchBlockDestroy++;
            Debug.Log(destroyList.howMuchBlockDestroy);
       
        }
    }
    void BulletMovement(){
        transform.Translate(Vector3.right * BulletSpeed * Time.deltaTime);
        if (transform.position.x == xBound){
            Destroy(gameObject);
        if(!walkBool.walk){
            if (transform.position.x > xBound)
            Destroy(gameObject);
            }
            
        }
        
    }
        
}
