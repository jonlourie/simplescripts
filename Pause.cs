using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        
            Time.timeScale = 0;

        //figure out how to press the same button for unpause agian
        //also add slowe function just because it would be cool 
      
           
    }
      
}
