using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImmediateJumpControllerCSR : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private GroundCheckerCSR groundCheckerCSR;
    [SerializeField] private float jumpForce = 500f;

    private void Update()
    {
        HandleJump();
    }
    
    private void HandleJump()
    {
        //Apply jump force
        //Preferably interact physics in FixedUpdate()
        if (commandContainer.JumpCommandDowen && groundCheckerCSR.IsGrounded)
            myRigidbody.AddForce(Vector3.up * jumpForce);

        
    }
}
