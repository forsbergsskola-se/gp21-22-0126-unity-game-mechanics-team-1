using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class AntiGravityEnemyAI : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] private Rigidbody rigidbody;
    
    [Header("Stats")]
    [SerializeField] private float walkSpeed;
    [SerializeField] private float movementAmplitude;
    [SerializeField] private float antiGravityForce;

    private Walk _walk;
    private AntiGravity _antiGravity;

    private bool canMove = true;

    private void Awake()
    {
        _walk = new Walk(rigidbody, walkSpeed);
        _antiGravity = new AntiGravity(antiGravityForce);
    }

    private void FixedUpdate()
    {
        if(canMove) Move();
    }

    private void Move()
    {
        var direction = Mathf.Sin(Time.time) * movementAmplitude;
        _walk.Move(direction);
    }

    private void OnTriggerStay(Collider other)
    {
        Rigidbody otherRb = other.GetComponent<Rigidbody>();
        
        if (otherRb == null) return;

        canMove = false;
        _antiGravity.InvertGravity(otherRb);
    }

    private void OnTriggerExit(Collider other)
    {
        Rigidbody otherRb = other.GetComponent<Rigidbody>();
        
        if (otherRb == null) return;
        
        canMove = true;
        _antiGravity.ReturnGravity(otherRb);
    }
}
