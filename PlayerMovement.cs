using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput, 0, 0) * speed * Time.deltaTime);

        //to hard input for this the eaasiest built in unity wayu is to use tyhe axis horizontal key or vertical
        //you could use an if statement for each direction but why bother 


        //this is an example of craziness - transform.Translate(new Vector3(1, 3, 4) * speed * Time.deltaTime);
    }
}
