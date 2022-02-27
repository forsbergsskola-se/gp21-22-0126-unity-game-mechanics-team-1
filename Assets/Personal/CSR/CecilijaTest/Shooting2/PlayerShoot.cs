// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class PlayerShootProjectiles : MonoBehaviour
// {
//     [SerializeField] private Transform pfBullit;
//
//     private void Awake()
//     {
//         GetComponent<CharacterAim_Base>().OnShoot += PlayerShootProjectiles_OnShoot;
//     }
//
//     private void PlayerShootProjectiles_OnShoot(object sender, CharacterAim_Base.OnShootEventArgs e)
//     {
//         Transform belletTransform = Instantiate(pfBullit, e.gunEndPointPosition, Quaternion.identity);
//
//         Vector3 shootDir = (e.shootPosition - e.gunEndPointPosition).normalized;
//         belletTransform.GetComponent<Bullet>().Setup(shootDir);
//     }
// }
//
//
