using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int moveSpeed = 10;
    public TowerManager walkBool;
    private Vector3 spawnPos = new Vector3(-19,1,0);
    public GameObject bullet; 
    public bool AmIHere = false;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        walkBool = GameObject.Find("TowerMmanager").GetComponent<TowerManager>();
      
    }

    // Update is called once per frame
    void Update()
    {   
        TruePosition();
        BulletCreate();
        MoveForward();
    }
        void MoveForward (){
        if(walkBool.walk){
            if(Input.GetKey(KeyCode.W)){
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

                     }
                }
        }
        void BulletCreate (){
            if(!walkBool.walk){
                 if (Input.GetKeyDown(KeyCode.Space)){
                 Vector3 spawnPoss = new Vector3(transform.position.x + 1.5f,transform.position.y,transform.position.z);
                Instantiate(bullet,spawnPoss,transform.rotation);
             }
            }
           
        }
        void TruePosition(){
    if(gameObject.transform.position.x >= 40){
        AmIHere = true;
        walkBool.walk = false;
     }
    }

}
    

