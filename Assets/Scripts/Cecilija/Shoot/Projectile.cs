using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    
    [SerializeField] private float speed;
    
    [SerializeField] Vector3 shootDirection;
    
    private void Start()
    {
        rigidbody.velocity = shootDirection * speed;
    }
    
    private void OnCollisionEnter(Collision other)
    { 
        if(!other.gameObject.CompareTag("Player")) Destroy(gameObject);
    }
}
