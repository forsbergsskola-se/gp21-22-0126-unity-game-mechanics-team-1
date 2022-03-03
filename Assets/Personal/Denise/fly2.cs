using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class fly2 : MonoBehaviour
{
   [SerializeField] internal float speed, flyT, flyMax, flyF, jumpF;
   [SerializeField] internal int score;
   private Rigidbody rg;
   private SphereCollider sx;
   private float h;
   private bool isFly, isJump;

   private void Awake()
   {
      rg = GetComponent<Rigidbody>();
      sx = GetComponent < SphereCollider();
   }

   private void Update()
   {
      h = Input.GetAxis("Horizontal");
      isFly = Input.GetKey("F");
      isJump = Input.GetKeyDown("F");
   }

   private void FixedUpdate()
   {
      Walk();
      Fly();
      Jump;

   }
}
