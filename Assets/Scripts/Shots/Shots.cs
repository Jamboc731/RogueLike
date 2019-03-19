using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shots : MonoBehaviour
{

    [SerializeField] float moveSpeed = 5;
    [SerializeField] float lifetime = 5;
    [SerializeField] float scaleAtEndOfLife = 1;
    [SerializeField] float damage = 1;

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
