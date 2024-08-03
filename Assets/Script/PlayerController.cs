using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    private Vector3 spawnPos = new Vector3(0,1,0);
    public GameObject bullet; 
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        BulletCreate();
    }
       
        void BulletCreate ()
        {
    
                 if (Input.GetKeyDown(KeyCode.Space))
            {
                 Vector3 spawnPoss = new Vector3(transform.position.x ,transform.position.y,transform.position.z +1.5f);
                Instantiate(bullet,spawnPoss,transform.rotation);
            }
        }
    
}
    

