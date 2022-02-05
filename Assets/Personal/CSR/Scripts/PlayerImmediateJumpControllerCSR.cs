using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImmediateJumpControllerCSR : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private PlayerInputControllerCSR playerInputControllerCSR;
    [SerializeField] private GroundCheckerCSR groundCheckerCSR;
    [SerializeField] private float jumpForce = 500f;
    private void Update()
    {
        //Apply jump force
        //Preferably interact physics in FixedUpdate()
        if (playerInputControllerCSR.JumpInputDown && groundCheckerCSR.IsGrounded)
            myRigidbody.AddForce(Vector3.up * jumpForce);

        
    }
}
