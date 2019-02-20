using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour {

    protected Vector2 target;
    protected float bulletSpeed;

	void Start () {
		
	}
	
	void Update () {
		
	}

    public void SetTarget(Vector2 newTarget)
    {
        target = newTarget;
    }

    protected void Aim()
    {
        Debug.Log("Aiming");
    }

}
