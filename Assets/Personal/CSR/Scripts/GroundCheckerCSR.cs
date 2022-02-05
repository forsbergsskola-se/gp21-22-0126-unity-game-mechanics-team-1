using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckerCSR : MonoBehaviour
{
    public bool IsGrounded { get; private set; }
    [SerializeField] private float groundCheckLenght = 1f;
    [SerializeField] private float groundCheckRadius = 0.5f;
    [SerializeField] private LayerMask groundLayers;
    private void Update()
    {
        var ray = new Ray(transform.position, Vector3.down);
        IsGrounded = Physics.SphereCast(ray, groundCheckRadius, groundCheckLenght, groundLayers);
        
        //Debug.DrawRay(transform.position, Vector3.down * groundCheckLenght, Color.green);
    }
    
}
