using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    
    public GameObject[] Deleted;
    public bool walk = false;
    public GameObject[] towerblocks;
    private int towerBlockCount = 0;
    public int howMuchBlockDestroy = 0;
 
   private List<GameObject> towerBlocks;
  Vector3 spawnPos = new Vector3 (0,25,0); 
    
    // Start is called before the first frame update
     void Start()
     
    {
      
       
    }

    // Update is called once per frame
    void Update()
    {
          towerBlocks = new List<GameObject>(GameObject.FindGameObjectsWithTag("towerblock"));
      towerBlockCount = towerBlocks.Count;
    
        TowerBlockCreator();
        LevelChanger();
        DeleteEveryone();
       
        
    }
   
        void TowerBlockCreator (){
       
        if(howMuchBlockDestroy <= 24){
                 if (towerBlockCount < 5 ){
        int towerindex = Random.Range(0,2);
        Instantiate(towerblocks[towerindex],spawnPos,towerblocks[towerindex].transform.rotation);
        howMuchBlockDestroy++;
        Debug.Log(howMuchBlockDestroy);
       
        }
       }
        }
        void LevelChanger (){
            if(howMuchBlockDestroy == 25){
                walk = true;
            }
        }
       void DeleteEveryone (){
        if(walk == true){
            Destroy(Deleted[0]);
            Destroy(Deleted[1]);
            
        }
       }
      
    }

