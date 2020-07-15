using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //All private variables
    private float speed = 10.0f;
    private float turnSpeed= 25;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player Inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // we move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime  * speed * forwardInput);
        // we can rotate vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * turnSpeed );
    }
}
