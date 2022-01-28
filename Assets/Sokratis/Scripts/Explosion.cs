using System;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float radius = 5f;
    [SerializeField] private float power = 10f;
    [SerializeField] private float upwardsModifier = 1f;

    private void Start()
    {
        //Explode();
    }

    public void Explode()
    {
        var explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Debug.Log(hit.gameObject.name);
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Debug.Log("Force has been applied");
                rb.AddExplosionForce(power, explosionPos, radius,upwardsModifier, ForceMode.Impulse);
            }
        }
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
