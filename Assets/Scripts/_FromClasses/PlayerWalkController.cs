using System;
using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private GroundChecker groundChecker;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float chargingMoveSpeedFactor = 0.5f;

    private Walk _walk;
    public bool CanWalk { get; set; }

    private void Awake()
    {
        _walk = new Walk(myRigidbody, moveSpeed);
        CanWalk = true;
    } 
    
    private void Update()
    {
        //Slower move speed while charging a jump.
        var currentMoveSpeed = moveSpeed;
        if (playerInputController.JumpInput && groundChecker.IsGrounded)
            currentMoveSpeed *= chargingMoveSpeedFactor;

        if(CanWalk) _walk.Move(playerInputController.MoveInput);
    }

    private void OnCollisionEnter(Collision other) => CanWalk = true;
}