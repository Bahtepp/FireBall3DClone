using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    
    void Start()
    {
        player = GameObject.Find("player");
    }

  
    void Update()
    {
       CameraFollow();
    }
    void CameraFollow(){
         transform.position = new Vector3(player.transform.position.x + 14.0f,player.transform.position.y + 5.5f,transform.position.z);
    }
}
