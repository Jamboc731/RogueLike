using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement {
    
    //set movespeed and get rb component
	void Start ()
    {
        speed = 200;
        rb = GetComponent<Rigidbody2D>();
	}

    //move the player based on parent move function
    public void MovePlayer(Vector2 dir)
    {
        Move(dir);
    }

    //"dodge"?
    public void Dodge()
    {
        Debug.Log("dodged");
    }

}
