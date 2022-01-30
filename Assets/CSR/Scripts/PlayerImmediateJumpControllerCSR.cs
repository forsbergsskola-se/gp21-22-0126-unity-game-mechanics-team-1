using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImmediateJumpControllerCSR : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private PlayerInputControllerCSR playerInputControllerCsr;
    [SerializeField] private float jumpForce = 500f;
    private void Update()
    {
        //Apply jump force
        //Preferably interact physics in FixedUpdate()
        if (playerInputControllerCsr.JumpInput)
            myRigidbody.AddForce(Vector3.up * jumpForce);

        
    }
}
