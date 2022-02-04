using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    Vector3 shootDirection;
    void FixedUpdate ()
    {
        this.transform.Translate(shootDirection * speed, Space.World);
    }

    public void FireProjectile(Ray shootRay)
    {
        this.shootDirection = shootRay.direction;
        this.transform.position = shootRay.direction;
    }
    
    
}
