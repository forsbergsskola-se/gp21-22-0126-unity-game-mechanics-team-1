using UnityEngine;

public class ExplosiveEnemyAI : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private Transform target;
    [SerializeField] private Explosion_1_Timer explosion;
    
    [Header("Stats")] 
    [SerializeField] private float range;
    [SerializeField] private float walkSpeed;
    
    private Walk _walk;
    
    
    private void Awake() => _walk = new Walk(rigidbody, walkSpeed);
    
    private void FixedUpdate()
    {
        var direction = target.transform.position - transform.position;
        
        if(direction.magnitude <= explosion.Radius) explosion.Trigger();
        
        Physics.SphereCast(transform.position, 1, direction, out RaycastHit hit, range);
        if (hit.transform == null || !hit.transform.gameObject.CompareTag("Player")) return;
        direction.x = Mathf.Clamp(hit.transform.position.x - transform.position.x, -1,1);
        
        _walk.Move(direction.x);
    }
    
    private void OnDrawGizmos() => Gizmos.DrawWireSphere(transform.position, range);
}
