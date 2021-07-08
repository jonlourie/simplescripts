using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rigidBody;
    public float speed;
    public Text countText; // from the UI
    private float zAxis;
    private float xAxis;
    private int gameCount;
    

    private void Start()
    {
        // the only comnponant you variable you do not have to work initialize is transform the machione will not know what youyr talking about if you dont do this
        //need to initialize the variable - so it knows what rigid body its getting
        // in code you arte simply communicating with the machgine here 
        rigidBody = GetComponent<Rigidbody>();
        gameCount = 0;
        SetCountText(); //must haver to string to convert it to a string 
    }


    private void Update()
    {
            

        xAxis = Input.GetAxis("Horizontal");
        zAxis = Input.GetAxis("Vertical");

    }

    void FixedUpdate()
    {

        //initially did not run because speed was 0 so everything esle was 0 - overall a better and more efficient way

        Vector3 movement = new Vector3(xAxis, 0.0f, zAxis); //create a new Vector3 variable to hold all the values of each axis with the get axis float variables 
        rigidBody.AddForce(movement * speed); // we do not need top place vector three in this line of code because it is already stored in the variables
        
        

    }

    void OnTriggerEnter (Collider other) //dertects a collider 
    {

        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            gameCount = gameCount + 1;
            SetCountText();
            //again game objecect is the instance of the GameObject class  
        }
           

    
       
       //game object set active is the code equivelent to setting the active check mark foir any object in the unity engine  in the unity layer it's a check mark sop it's bool
    }

    void SetCountText()
    {
        countText.text = "Count: " + gameCount.ToString();
    }
}
