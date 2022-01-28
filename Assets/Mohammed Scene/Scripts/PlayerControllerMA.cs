using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerMA : MonoBehaviour
{
    public float moveInput;
    public Rigidbody myRigidbody;
    public float speed;

    
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        myRigidbody.velocity = new Vector3(speed * moveInput, myRigidbody.velocity.y);
    }
}
