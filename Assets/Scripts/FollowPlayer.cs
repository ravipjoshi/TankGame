using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 offset = new Vector3(0, 6, -8);
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Offset Behind the player by adding to the player's position
        //transform.position = player.transform.position + new Vector3 (0,5,-7);

        //Offset Behind the player by adding to the player's position with vector3 variable
        transform.position = player.transform.position + offset;
    }
}
