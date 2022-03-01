using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class Wapen : MonoBehaviour
{
    //
    public float timeToDisappear = 10;
    public Camera fpsCam;
    public enum ShootState 
    {
        Ready,
        Shooting,
        Reloading
       
    }
    
    private float muzzleOffset;

    [Header("Magazine")]
    public GameObject round;
    public int ammunition;

    [Range(0.5f, 10)] public float reloadTime;

    private int remainingAmmunition;

    [Header("Shooting")]
    [Range(0.25f, 25)] public float fireRate;
    
    public int roundsPerShot;

    [Range(0.5f, 100)] public float roundSpeed;

    
    [Range(0, 45)] public float maxRoundVariation;

    private ShootState shootState = ShootState.Ready;
    
    private float nextShootTime = 0;

    void Start() 
    {
        muzzleOffset = GetComponent<Renderer>().bounds.extents.z;
        remainingAmmunition = ammunition;
        

    }

    void Update() {
        switch(shootState) 
        {
            case ShootState.Shooting:
                
                if(Time.time > nextShootTime) 
                {
                    shootState = ShootState.Ready;
                }
                break;
            case ShootState.Reloading:
               
                if(Time.time > nextShootTime) 
                {
                    remainingAmmunition = ammunition;
                    shootState = ShootState.Ready;
                }
                break;
        }
    }

    
    public void Shoot() 
    {
        
        if(shootState == ShootState.Ready) 
        {
            for(int i = 0; i < roundsPerShot; i++) 
            {
                
                GameObject spawnedRound = Instantiate
                (
                    round,
                    transform.position + transform.forward* muzzleOffset,
                    transform.rotation
                     
                    
                );
                
                
                spawnedRound.transform.Rotate(new Vector3
                (
                    Random.Range(-1f, 1f) * maxRoundVariation,
                    Random.Range(-1f, 1f) * maxRoundVariation,
                    0
                ));
                
                StartCoroutine(DisappearCoroutine(spawnedRound.gameObject));
                
            }

            remainingAmmunition--;
            if(remainingAmmunition > 0) 
            {
                nextShootTime = Time.time + (1 / fireRate);
                shootState = ShootState.Shooting;
            } else 
            
            {
                Reload();
            }
        }
        
    }

   
    public void Reload() {
       
        if(shootState == ShootState.Ready) 
        {
            nextShootTime = Time.time + reloadTime;
            shootState = ShootState.Reloading;
        }
    }
    private IEnumerator DisappearCoroutine(GameObject bulletToDisappear) 
    {
        yield return new WaitForSeconds(timeToDisappear);
        Destroy(bulletToDisappear);
    }
    
    
}