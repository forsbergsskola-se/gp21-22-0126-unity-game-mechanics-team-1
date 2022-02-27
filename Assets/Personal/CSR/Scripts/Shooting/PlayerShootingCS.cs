using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingCS : MonoBehaviour
{
    public Wapen gun;
    //public bool constrainteActive;

    public int shootButton;
    public KeyCode reloadKey;

    [SerializeField] private PlayerInputControllerCSR _inputControllerCSR;
    void Update() {
        if(Input.GetMouseButton(shootButton)) {
            gun.Shoot();
        }

        if(Input.GetKeyDown(reloadKey)) {
            gun.Reload();
        }
    }
    
}


// private Camera fpsCam;  
    // //public Camera fpsCam;
    // public ProjectileCS projectilePrefab;
    // public LayerMask mask;
    //
    // void shoot(RaycastHit hit){
    //    
    //     var projectile = Instantiate(projectilePrefab).GetComponent<ProjectileCS>();
    //     var pointAboveFloor = hit.point + new Vector3(0, this.transform.position.y, 0);
    //     var direction = pointAboveFloor - transform.position;
    //     var shootRay = new Ray(this.transform.position, direction);
    //     
    //     Debug.DrawRay(shootRay.origin, shootRay.direction * 100.1f, Color.green, 200);
    //     Physics.IgnoreCollision(GetComponent<Collider>(), projectile.GetComponent<Collider>());
    //     projectile.FireProjectile(shootRay);
    // }
    //
    //
    // void raycastOnMouseClick () 
    // {
    //     RaycastHit hit;
    //     var rayToFloor = Camera.main.ScreenPointToRay(Input.mousePosition);
    //     Debug.DrawRay(rayToFloor.origin, rayToFloor.direction * 100.1f, Color.red, 2);
    //
    //     if(Physics.Raycast(rayToFloor, out hit, 100.0f, mask, QueryTriggerInteraction.Collide)) 
    //     
    //     {
    //         shoot(hit);
    //     }
    // }
    //
    // void Update () 
    // {
    //     bool mouseButtonDown = Input.GetMouseButtonDown(0);
    //  
    //     if(mouseButtonDown) 
    //         
    //     {
    //         raycastOnMouseClick();  
    //     }
    //     
    //  
    // }
    

