using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> towerManagers;
    public TowerManager towerManager;
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        towerManager = towerManagers[0].GetComponent<TowerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        DestroyTower();
        ActiveTower();
    }
    void DestroyTower(){
        if(!towerManager.isActive){
            towerManagers[0].SetActive(false);
            towerManager.isActive = true;
            
           
        }

    }
    void ActiveTower(){
        if(playerController.AmIHere){

            towerManagers[0].SetActive(true);
           
            towerManager.setTower = true;
            
           
        }
    }
     
    
   
}
