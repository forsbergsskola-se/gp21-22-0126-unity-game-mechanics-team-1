// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class Bullet : MonoBehaviour
// {
//     private Vector3 shootDir;
//     public void Setup(Vector3 shootDir)
//     {
//         this.shootDir = shootDir;
//         transform.eulerAngles = new Vector3(0, 0, UtilsClass.GetAngleFormVectorFloat(shootDir));
//         Destroy(gameObject, 5f);
//     }
//
//     private void Update()
//     {
//         float moveSpeed = 100f;
//         transform.position += shootDir * moveSpeed * Time.deltaTime;
//
//         float hitDetectionSize = 3f;
//         Target target = Target.GetClosest(transform.position, hitDetectionSize);
//         if (target != null)
//         {
//             target.Damage();
//             Destroy(gameObject);
//         }
//     }
// }
