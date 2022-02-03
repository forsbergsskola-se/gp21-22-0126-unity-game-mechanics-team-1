using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMA : MonoBehaviour
{
   [SerializeField] private Rigidbody rigidbody;
   [SerializeField] private float speed;

   private void Update()
   {
      rigidbody.velocity = new Vector3(speed, 0f, 0f);

   }

   private void OnCollisionEnter(Collision Collision)
   {
      Destroy(gameObject);
   }
   
}
