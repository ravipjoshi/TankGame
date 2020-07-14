using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We will add code here to forawrd the  vehicle
        //transform.Translate(0, 0, 1);

        // Forward a vehicle with vector3 which is shorthand style of above function
        //transform.Translate(Vector3.forward);

        // Slowing down a speed of a vehicle from above  function

        transform.Translate(Vector3.forward * Time.deltaTime  * 20);
    }
}
