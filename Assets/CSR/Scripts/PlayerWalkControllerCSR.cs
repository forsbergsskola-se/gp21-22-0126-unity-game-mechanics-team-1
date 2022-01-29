using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkControllerCSR : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float moveSpeed = 5f;

    private void Update()
    {
        //Preferably get input in Update()
        var moveInput = Input.GetAxis("Horizontal");

        //Preferably interact with physics in FixedUpdate()
        myRigidbody.velocity = new Vector3(moveInput * moveSpeed, myRigidbody.velocity.y, 0);
    }
}
