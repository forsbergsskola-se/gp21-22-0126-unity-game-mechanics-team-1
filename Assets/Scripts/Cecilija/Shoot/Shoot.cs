using System;
using UnityEngine;

public class Shoot : MonoBehaviour
{
   [SerializeField] private PlayerInputController _inputController;
   [SerializeField] private GameObject bullet;

   private void Update()
   {
      if (_inputController.ShootInput) Instantiate(bullet, this.transform.position, Quaternion.identity);
   }
}
