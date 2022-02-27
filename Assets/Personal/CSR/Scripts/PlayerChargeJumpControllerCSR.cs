using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChargeJumpControllerCSR : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private GroundCheckerCSR groundCheckerCSR;
    [SerializeField] private float minimumJumpForce = 100f;
    [SerializeField] private float maximumJumpForce = 1000f;
    [SerializeField] private float chargeTime = 1f;

    private float jumpCharge;

    private void Update()
    {
        HandleJump();
    }
    
    private void HandleJump()
    {
        if (commandContainer.JumpICommand)
            jumpCharge += Time.deltaTime / chargeTime;

        if (commandContainer.JumpCommandUp)
        {
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, jumpCharge);
            jumpCharge = 0f;
            
            if(groundCheckerCSR.IsGrounded)
            myRigidbody.AddForce(Vector3.up * jumpForce);
        }
            

        
    }
}
