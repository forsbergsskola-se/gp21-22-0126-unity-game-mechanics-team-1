using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeDashMA : MonoBehaviour
{
    [SerializeField] private float moveInput;
    [SerializeField] Rigidbody myRigidbody;
    [SerializeField] private float speed;

    [SerializeField] private float dashSpeed;
    [SerializeField] private float dashTime;
    [SerializeField] private  float dashTimeCounter = 0f;
    [SerializeField] private float chargeTime = 1f;
    
    
    private bool canDash;
    private bool canWalk;
    
    private float dashCharge;

    private void Start()
    {
        canDash = true;
        canWalk = true;
    }

    void Update()
    {
        /*
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
        */
        if (Input.GetKey(KeyCode.Q))
        {
            dashCharge += Time.deltaTime / chargeTime;
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            dashCharge = Mathf.Clamp(dashCharge, 0f, 1f);
            
            StartCoroutine(dash(dashCharge));
            Debug.Log(dashCharge);
            dashCharge = 0f;
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
