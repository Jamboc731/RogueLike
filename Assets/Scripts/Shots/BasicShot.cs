using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicShot : Shots
{

    Vector2 dir;

    public void SetDir(Vector2 _dir)
    {
        dir = _dir;
    }

    private void Update ()
    {
        Move (dir);
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        Destroy (gameObject);
        //Debug.Log ("hit");
        //Debug.Log (collision.collider.gameObject.name);
        if (collision.collider.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log ("tagged enemy");
            collision.collider.gameObject.GetComponent<Enemy> ().TakeDamage (damage);
        }
    }

}
