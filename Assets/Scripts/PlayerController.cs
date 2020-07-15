using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed= 25;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // We will add code here to forawrd the  vehicle
        //transform.Translate(0, 0, 1);

        // Forward a vehicle with vector3 which is shorthand style of above function
        //transform.Translate(Vector3.forward);

        // Slowing down a speed of a vehicle from above  function

        transform.Translate(Vector3.forward * Time.deltaTime  * speed * forwardInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * turnSpeed );
    }
}
