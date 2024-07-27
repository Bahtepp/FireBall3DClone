using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public GameObject[] towerblocks;
    private int towerBlockCount = 0;
 
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

        
    }
   
        void TowerBlockCreator (){
            if (towerBlockCount < 5 ){
        int towerindex = Random.Range(0,2);
        Instantiate(towerblocks[towerindex],spawnPos,towerblocks[towerindex].transform.rotation);
       }
        }
    }

