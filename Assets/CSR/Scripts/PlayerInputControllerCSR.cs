using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputControllerCSR : MonoBehaviour
{
    public float MoveInput { get; private set; }
    public bool JumpInput { get; private set; }
    //private bool jumpInput;
    //public bool JumpInput => jumpInput;
    
   private void Update()
   {
       MoveInput = Input.GetAxis("Horizontal");
       JumpInput = Input.GetKeyDown(KeyCode.Space);
   }
}
