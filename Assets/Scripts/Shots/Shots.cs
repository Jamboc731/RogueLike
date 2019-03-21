using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shots : MonoBehaviour
{

    [SerializeField] protected float moveSpeed = 5;
    [SerializeField] protected float lifetime = 5;
    [SerializeField] protected float scaleAtEndOfLife = 1;
    [SerializeField] protected int damage = 1;

    public void Move(Vector2 dir)
    {
        transform.Translate (dir * moveSpeed * Time.deltaTime);
    }	

    public float GetLifetime ()
    {
        return lifetime;
    }

    public void ChangeScale(float newScale)
    {
        
    }

}
