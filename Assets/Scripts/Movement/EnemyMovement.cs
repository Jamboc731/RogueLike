using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : Movement {

    [SerializeField]
    private Transform player;

	void Start () {
        speed = 150;
        rb = GetComponent<Rigidbody2D>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        ChasePlayer();
	}

    private void ChasePlayer()
    {
        Vector2 dir = player.transform.position - transform.position;
        Move(dir);
    }


}
