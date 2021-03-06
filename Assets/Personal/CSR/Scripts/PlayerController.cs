using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float moveSpeed = 5f;
    public float jumpForce = 500f;
    
    
    private void Update()
    {
        //Preferably get input in Update()
        var moveInput = Input.GetAxis("Horizontal");

        //Preferably interact with physics in FixedUpdate()
        myRigidbody.velocity = new Vector3(moveInput * moveSpeed, myRigidbody.velocity.y, 0);


        //Get jump input
        //Preferably get input in Update()
        var jumpInput = Input.GetKeyDown(KeyCode.Space);

        //Apply jump force
        //Preferably interact physics in FixedUpdate()
        if (jumpInput)
            myRigidbody.AddForce(Vector3.up * jumpForce);
        
        

    }
    
}