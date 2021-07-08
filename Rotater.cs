using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

        // new isa exactly what it says whenever you establisdhing a new thing 
        transform.Rotate(new Vector3(20, 11, 45) * Time.deltaTime);//action has to be frame rate independednt something quick to multiply by it by
    }
}

