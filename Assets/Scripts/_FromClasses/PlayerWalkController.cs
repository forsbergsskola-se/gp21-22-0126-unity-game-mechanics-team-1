using System;
using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private GroundChecker groundChecker;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float chargingMoveSpeedFactor = 0.5f;
    
    public bool CanWalk { get; set; }

    private void Awake() => CanWalk = true;
    
    private void Update()
    {
        //Slower move speed while charging a jump.
        var currentMoveSpeed = moveSpeed;
        if (playerInputController.JumpInput && groundChecker.IsGrounded)
            currentMoveSpeed *= chargingMoveSpeedFactor;

        if(CanWalk) myRigidbody.velocity = new Vector3(playerInputController.MoveInput * currentMoveSpeed, myRigidbody.velocity.y, 0);
    }

    private void OnCollisionEnter(Collision other) => CanWalk = true;
}