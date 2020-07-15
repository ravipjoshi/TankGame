using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // public variable    
    public GameObject player;
    //private variable
    private Vector3[] offset = new[] { new Vector3(0, 6, -8), new Vector3(0, 5, -7), new Vector3(0, 5, -8), new Vector3(0,5,0) };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int counter =  0;
        //Offset Behind the player by adding to the player's position with vector3 variable
        transform.position = player.transform.position + offset[2];
        if (Input.GetKeyDown(KeyCode.C))
        {
            
            if (counter == 0)
            {
                transform.position = player.transform.position + offset[counter];
                counter++;
            }
            else if(counter == 1)
            {
                transform.position = player.transform.position + offset[counter];
                counter++;
            }
            else if(counter ==2)
            {
                transform.position = player.transform.position + offset[counter];
            }
            else
            {
                transform.position = player.transform.position + offset[counter];
                counter = 0;
            }
        }
    }
}
