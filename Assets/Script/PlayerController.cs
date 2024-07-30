using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int moveSpeed = 5;
    public TowerManager walkBool;
    private Vector3 spawnPos = new Vector3(-19,1,0);
    public GameObject bullet; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        walkBool = GameObject.Find("TowerManager").GetComponent<TowerManager>();
    }

    // Update is called once per frame
    void Update()
    {   

        if (Input.GetKeyDown(KeyCode.Space)){
        Instantiate(bullet,spawnPos,bullet.transform.rotation);
        }
       MoveForward();
    }
     void MoveForward (){
        if(walkBool.walk == true){
            if(Input.GetKey(KeyCode.W)){
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

            }
        }
       }
}
    

