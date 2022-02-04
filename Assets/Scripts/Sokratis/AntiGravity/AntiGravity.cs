using UnityEngine;

public class AntiGravity
{
    private float _force;

    public AntiGravity(float force) => _force = force;
    
    public void InvertGravity(Rigidbody rigidbody)
    {
        rigidbody.useGravity = false;
        rigidbody.AddForce(new Vector3(0, _force, 0), ForceMode.Acceleration);
    }

    public void ReturnGravity(Rigidbody rigidbody) => rigidbody.useGravity = true;
}
