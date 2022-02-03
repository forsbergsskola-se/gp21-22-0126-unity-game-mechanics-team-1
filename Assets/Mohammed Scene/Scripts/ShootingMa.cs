using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingMa : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
       GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
      Rigidbody MR= bullet.GetComponent<Rigidbody>();
      MR.AddForce(firePoint.up*bulletForce,ForceMode.Impulse);
    }
}
