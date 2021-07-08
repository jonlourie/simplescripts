using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 offsetValue;

    // Start is called before the first frame update
    void Start()
    {
        //think about math in plain english thats all it is 
        //we do not need to initialize transform in this game object or any game object 

        //offeset value is how we determine the difference between thesde two positions from the get go 

        offsetValue = transform.position - player.transform.position;

       
    }

    // Update is called once per frame
    void LateUpdate() // runs every frame guerenteed to run after all items proccessed - for camera follows, procedural animations, gathering last known states 
    {

        //n every frame the  position of the camera is matched to the players position plus the cameras position without the players position or the difference - 
        transform.position = player.transform.position + offsetValue;

    }

    //if you just read math like simple english it would be the cameras postion is a combo of the players position plus the camera posiution the cameras not rotating so neither will the new position
    //the problem can be summed up like this - instead of making t5he camera position = to that of the player - we align player with the camera in addition to the difference between the two points every frame 


}

