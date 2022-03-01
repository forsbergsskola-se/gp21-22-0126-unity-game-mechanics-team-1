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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
       Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
    }
}
