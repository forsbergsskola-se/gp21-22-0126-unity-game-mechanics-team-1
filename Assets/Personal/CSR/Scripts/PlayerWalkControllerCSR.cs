using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkControllerCSR : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private PlayerInputControllerCSR playerInputControllerCSR;
    [SerializeField] private GroundCheckerCSR groundCheckerCSR;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float chargingMoveSpeedFactor = 0.5f;

    private void Update()
    {
        //Slower move speed while charging a jump.
        var currentMoveSpeed = moveSpeed;
        if (playerInputControllerCSR.JumpInput && groundCheckerCSR.IsGrounded)
            currentMoveSpeed *= chargingMoveSpeedFactor;
        
        myRigidbody.velocity = new Vector3(playerInputControllerCSR.MoveInput * currentMoveSpeed, myRigidbody.velocity.y, 0);
    }
}
