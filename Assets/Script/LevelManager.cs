using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<int> levels;

    public int gap =5;
    public int step = 1;
    public int yOffset= 1;
    
    public GameObject blockerPrefabs;
    public GameObject[] towerBlocks;
    public GameObject boundZ;
    // Start is called before the first frame update
    void Start()
    {
        //0 space ,  1 block, else blocknumber,2 destroyBullet
       levels = new List<int>(){
        1,1,5,2
       };
       CreateLevel();
    }
    public void CreateLevel()
    {


        foreach(var i in levels)
        {
            if(i == 0)
            {


            }
            else if(i==1)
            { 
                var newBlock = Instantiate(blockerPrefabs);
                newBlock.transform.position = new Vector3(0,1.5f,gap * step);  

            }
            else if(i==2){
                var newBound = Instantiate(boundZ);
                newBound.transform.position = new Vector3(0,0,step * gap);
            }
            else
            {
              int lastElement = levels[levels.Count - 2];
                for (int p = 0; p < lastElement; p++)
                {
                    if(p % 2 == 0)
                    {
                        var newTowerBlock2 = Instantiate(towerBlocks[1]);
                   
                   newTowerBlock2.transform.position = new Vector3 (0,yOffset,gap * step);
                   yOffset += 2; 
                    }else
                    {
                        var newTowerBlock = Instantiate(towerBlocks[0]);
                   newTowerBlock.transform.position = new Vector3 (0,yOffset,gap * step);
                   yOffset += 2; 
                    }
                   
                }
                

            }
            step++;
        }
    }
    }
