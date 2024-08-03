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
    public GameObject towerBlocks;
    // Start is called before the first frame update
    void Start()
    {
        //0 space ,  1 block, else blocknumber
       levels = new List<int>(){
        1,1,5
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
                newBlock.transform.position = new Vector3(0,1.5f,gap*step);  

            }
            else
            {
              int lastElement = levels[levels.Count - 1];
                for (int p = 0; p < lastElement; p++)
                {
                   var newTowerBlock = Instantiate(towerBlocks);
                   
                   newTowerBlock.transform.position = new Vector3 (0,yOffset,gap * step);
                   yOffset += 2; 
                }
                

            }
            step++;
        }
    }
    }
