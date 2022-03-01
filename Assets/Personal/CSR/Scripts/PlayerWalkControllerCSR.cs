using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkControllerCSR : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private CommandContainer commandConteiner;
    [SerializeField] private GroundCheckerCSR groundCheckerCSR;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float chargingMoveSpeedFactor = 0.5f;

    private void Update() => HandleWalking();

    private void HandleWalking()
    {
        //Slower move speed while charging a jump.
        var currentMoveSpeed = moveSpeed;
        if (commandConteiner.JumpICommand && groundCheckerCSR.IsGrounded)
            currentMoveSpeed *= chargingMoveSpeedFactor;

        myRigidbody.velocity = new Vector3(commandConteiner.walkCommand * currentMoveSpeed, myRigidbody.velocity.y, 0);
    }
}
