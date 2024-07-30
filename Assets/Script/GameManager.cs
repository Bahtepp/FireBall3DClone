using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> towerManagers;
    public TowerManager changeActive;
    // Start is called before the first frame update
    void Start()
    {
        changeActive = towerManagers[0].GetComponent<TowerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        DestroyTower();
    }
    void DestroyTower(){
        if(!changeActive.isActive){
            towerManagers[0].SetActive(false);
           
        }
    }
}
