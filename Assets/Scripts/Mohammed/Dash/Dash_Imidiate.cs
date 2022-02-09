using System.Collections;
using UnityEngine;

public class Dash_Imidiate
{
    private Rigidbody _rigidbody;
    private float _speed;
    private float _time;

    private bool canWalk = true;
    private bool canDash = true;
    
    public Dash_Imidiate(Rigidbody rb, float speed, float time)
    {
        _rigidbody = rb;
        _speed = speed;
        _time = time;
    }

    public IEnumerator Execute(float input)
    {
        float timeCounter = 0f;
        canDash = false;
        canWalk = false;
        
        while (timeCounter <= _time)
        {
            _rigidbody.velocity = new Vector3(_speed * input, _rigidbody.velocity.y);
            timeCounter += Time.deltaTime;
            yield return null;
        }

        _rigidbody.velocity = Vector3.zero;

        canDash = true;
        canWalk = true;
        
        yield return null;
    }

    public bool CanWalk() => canWalk;
    public bool CanDash() => canWalk;
}
