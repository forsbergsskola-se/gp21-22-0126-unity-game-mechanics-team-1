using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerControllerMA : MonoBehaviour
{
    [SerializeField] private float moveInput;
   [SerializeField] Rigidbody myRigidbody;
   [SerializeField] private float speed;

    [SerializeField] private float dashSpeed;
    [SerializeField] private float dashTime;
    [SerializeField] private  float dashTimeCounter = 0f;

    private bool canDash;
    private bool canWalk;

    private void Start()
    {
        canDash = true;
        canWalk = true;
    }

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.W) && canDash && moveInput != 0 )
        {
            canDash = false;
            canWalk = false;
            var inputNormalized = Mathf.Sign(moveInput);
            StartCoroutine(dash(inputNormalized));
            
        }
        else if(canWalk)
        {
            
            myRigidbody.velocity = new Vector3(speed * moveInput, myRigidbody.velocity.y);  
        }
    }
    
    private IEnumerator dash(float input)
    {
        while (dashTimeCounter <= dashTime )
        {
            myRigidbody.velocity = new Vector3(dashSpeed * input, myRigidbody.velocity.y);
            dashTimeCounter += Time.deltaTime;
            yield return null;
        }
        myRigidbody.velocity = Vector3.zero;
    
        canDash = true;
        canWalk = true;
        dashTimeCounter = 0f;
        Debug.Log(canDash);
        yield return null;
    }
}
