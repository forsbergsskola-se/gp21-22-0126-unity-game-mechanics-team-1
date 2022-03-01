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

    private bool _canMove = true;

    private void Awake()
    {
        _walk = new Walk(rigidbody, walkSpeed);
        _antiGravity = new AntiGravity(antiGravityForce);
    }

    private void FixedUpdate()
    {
        if (_canMove) Move();
        else rigidbody.velocity = new Vector3(0, 0, 0);
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

        _canMove = false;
        _antiGravity.InvertGravity(otherRb);
    }

    private void OnTriggerExit(Collider other)
    {
        Rigidbody otherRb = other.GetComponent<Rigidbody>();
        
        if (otherRb == null) return;
        
        _canMove = true;
        _antiGravity.ReturnGravity(otherRb);
    }
}
