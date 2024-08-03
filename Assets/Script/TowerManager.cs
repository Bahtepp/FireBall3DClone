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

    public bool setTower = false;
     public int howMuchBlockDestroy = 0;
     private int towerBlockNumber = 10;
 
     public List<GameObject> towerBlocks;
     public GameObject towerBlock;
    
     public GameObject parentObject;
     
     public float xCordinate = 0;
     public float yCordinate = 25;
     public float zCordinate = 0;

     Vector3 spawnPos ;
     
     
 
    
    // Start is called before the first frame update
     void Start()
    {
         
     TowerBlockCreator(); 
    }

    // Update is called once per frame
    void Update()
    {  
        LevelChanger(); 
        SetLevelTwo();
    }
     void DefaultBlock(){
            Vector3 spawnPos = new Vector3 (xCordinate,yCordinate,zCordinate);
            Debug.Log(spawnPos + "level 2 icin");
            var blockRenderer = towerBlock.GetComponent<Renderer>();
                   blockRenderer.sharedMaterial.SetColor("_Color", Color.magenta);
            Instantiate(towerBlock,spawnPos,transform.rotation,parentObject.transform);
        } 
  
   
        void TowerBlockCreator (){
            
            for(int i = 0;i <=towerBlockNumber; i++){
                   DefaultBlock();
                towerBlocks.Add(towerBlock);
                
                  
                
            }
        }

  

    void LevelChanger (){
            if(howMuchBlockDestroy == towerBlockNumber){
                walk = true;
                towerBlockNumber += 5;
                isActive = false; 
                
                
                 }
        }   
        //level 2 yapmıyo sınırsız üretiyo
       void SetLevelTwo (){
        if(setTower){
            setTower = false;
            xCordinate = 60;
            yCordinate = 25;
            zCordinate = 0;
            spawnPos = new Vector3(xCordinate,yCordinate,zCordinate);
            TowerBlockCreator();
            
            Debug.Log(spawnPos + "setleveldaki");
        }
       }
       
    }

