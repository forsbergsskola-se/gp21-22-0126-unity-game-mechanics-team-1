using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class Explosion : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private float radius = 5f;
    [SerializeField] private float power = 10f;
    [SerializeField] private float upwardsModifier = 1f;

    [Header("Timer")] 
    [SerializeField] private float seconds;
    [SerializeField] private Material material;
    [SerializeField] private Color finalColor;

    private Color _initialColor;
    private float _elapsedTime;
    
    private void Awake()
    {
        _initialColor = material.color;
    }

    public void Trigger() => StartCoroutine(Charge());

    private IEnumerator Charge()
    {
        StartCoroutine(ChangeColor());
        
        yield return new WaitForSeconds(seconds);
        
        Explode();
    }

    private IEnumerator ChangeColor()
    {
        while (_elapsedTime <= 1)
        {
            _elapsedTime += Time.deltaTime / seconds;
            material.color = Color.Lerp(_initialColor, finalColor, _elapsedTime);
            
            yield return  null;
        }
    }

    private void Explode()
    {
        var explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            
            if (rb != null) 
                rb.AddExplosionForce(power, explosionPos, radius,upwardsModifier, ForceMode.Impulse);
        }

        material.color = _initialColor;
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
