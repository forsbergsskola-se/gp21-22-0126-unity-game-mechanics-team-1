using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class LandMine : MonoBehaviour
{
    [Header("Dependencies")] 
    [SerializeField] private SphereCollider sphereCollider;
    [SerializeField] private Explosion_1_Timer explosion;

    private void Start() => sphereCollider.radius = explosion.Radius / 2;

    private void OnTriggerEnter(Collider other) => explosion.Trigger();

}
