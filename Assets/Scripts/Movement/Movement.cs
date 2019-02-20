using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    [SerializeField]
    protected float speed;

    protected Rigidbody2D rb;
	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    protected void Move(Vector2 dir)
    {
        rb.velocity = dir.normalized * speed * Time.deltaTime;
        Debug.Log(dir);
    }

}
