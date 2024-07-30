using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    

     public bool walk = false;
     public bool isActive = true;

     public int howMuchBlockDestroy = 0;
 
     public List<GameObject> towerBlocks;
     public GameObject towerBlock;
    
     public GameObject parentObject;
     
     Vector3 spawnPos = new Vector3 (0,25,0); 
 
    
    // Start is called before the first frame update
     void Start()
    {
     TowerBlockCreator(); 
    }

    // Update is called once per frame
    void Update()
    {  
        LevelChanger(); 
    }
   
        void TowerBlockCreator (){
            
            for(int i = 0;i <=25; i++){
                Instantiate(towerBlock,spawnPos,transform.rotation,parentObject.transform);
                towerBlocks.Add(towerBlock);
            }
        }

  

    void LevelChanger (){
            if(howMuchBlockDestroy == 25){
                walk = true;
                isActive = false; 
                
            }
        }  
    }

