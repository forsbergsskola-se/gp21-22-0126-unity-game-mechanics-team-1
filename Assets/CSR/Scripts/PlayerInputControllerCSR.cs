using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputControllerCSR : MonoBehaviour
{
   public float moveInput;
   public bool jumpInput;
   private void Update()
   {
       moveInput = Input.GetAxis("Horizontal");
       jumpInput = Input.GetKeyDown(KeyCode.Space);
   }
}
