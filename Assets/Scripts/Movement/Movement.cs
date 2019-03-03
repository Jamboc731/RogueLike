using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    [SerializeField]
    protected float speed;

    protected Rigidbody2D rb;

    protected void Move(Vector2 dir)
    {
        rb.velocity = dir.normalized * speed * Time.deltaTime;
    }

    public Vector2 GetRBVelocity ()
    {
        return rb.velocity;
    }

}
