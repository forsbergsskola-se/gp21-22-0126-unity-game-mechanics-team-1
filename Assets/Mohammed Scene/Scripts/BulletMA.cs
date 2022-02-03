using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMA : MonoBehaviour
{
   
   private void OnCollisionEnter(Collision Collision)
   {
      Destroy(gameObject);
   }
}
