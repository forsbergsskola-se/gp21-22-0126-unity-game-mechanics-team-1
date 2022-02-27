using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputControllerCSR : MonoBehaviour
{
    [SerializeField] private CommandContainer commandContainer;
    
    //Currently these fields are not accessed from other scripts. 
    //But I'll leave them public to show en exemlpe of public getter with private setter. 
    public float WalkInput { get; private set; }
    public bool JumpInputDown { get; private set; }
    public bool JumpInputUp { get; private set; }
    public bool JumpInput { get; private set; }
    
    public bool ShootInput { get; private set; }

    private void Update()
    {
        GetInput();
        SetCommand();
    }
    
    private void GetInput()
   {
       WalkInput = Input.GetAxis("Horizontal");
       JumpInputDown = Input.GetKeyDown(KeyCode.Space);
       JumpInputUp = Input.GetKeyUp(KeyCode.Space);
       JumpInput = Input.GetKey(KeyCode.Space);
   }
    
    private void SetCommand()
    {
        commandContainer.walkCommand = WalkInput;
        commandContainer.JumpCommandDowen = JumpInputDown;
        commandContainer.JumpCommandUp = JumpInputUp;
        commandContainer.JumpICommand = JumpInput;
        ShootInput = Input.GetMouseButtonDown(0);
    }
}
