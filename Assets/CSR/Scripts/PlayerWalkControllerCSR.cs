using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkControllerCSR : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private PlayerInputControllerCSR playerInputControllerCsr;
    [SerializeField] private float moveSpeed = 5f;

    private void Update()
    {
        //Set move velocity
        //Preferably interact with physics in FixedUpdate()
        myRigidbody.velocity = new Vector3(playerInputControllerCsr.MoveInput * moveSpeed, myRigidbody.velocity.y, 0);
    }
}
