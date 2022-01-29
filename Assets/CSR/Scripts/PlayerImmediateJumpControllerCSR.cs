using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImmediateJumpControllerCSR : MonoBehaviour
{
    public Rigidbody myRigidbody;
    
    public float jumpForce = 500f;
    private void Update()
    {
        //Get jump input
        //Preferably get input in Update()
        var jumpInput = Input.GetKeyDown(KeyCode.Space);

        //Apply jump force
        //Preferably interact physics in FixedUpdate()
        if (jumpInput)
            myRigidbody.AddForce(Vector3.up * jumpForce);

        
    }
}
