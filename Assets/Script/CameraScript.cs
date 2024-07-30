using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
       CameraFollow();
    }
    void CameraFollow(){
         transform.position = new Vector3(player.transform.position.x + 14.0f,player.transform.position.y + 5.5f,transform.position.z);
    }
}
