using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 spawnPos = new Vector3(-19,1,0);
    public GameObject bullet; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space)){
        Instantiate(bullet,spawnPos,bullet.transform.rotation);
        }
    }
}
    

