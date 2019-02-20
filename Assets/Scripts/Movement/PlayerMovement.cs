using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement {
    
	void Start ()
    {
        speed = 200;
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        
    }

    public void MovePlayer(Vector2 dir)
    {
        Move(dir);
    }

    public void Dodge()
    {
        Debug.Log("dodged");
    }

}
