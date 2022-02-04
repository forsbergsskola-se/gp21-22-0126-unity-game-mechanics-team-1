using UnityEngine;

public class Walk
{
    private Rigidbody _rigidbody;
    private float _speed;

    public Walk(Rigidbody rigidbody, float speed)
    {
        _rigidbody = rigidbody;
        _speed = speed;
    }

    public void Move(float direction) =>
        _rigidbody.velocity = new Vector3(direction * _speed, _rigidbody.velocity.y, 0);
}
