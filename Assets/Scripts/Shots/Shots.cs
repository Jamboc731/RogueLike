using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shots : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] float lifetime = 5;

    public void Move(Vector2 dir)
    {
        transform.Translate (dir * moveSpeed * Time.deltaTime);
    }	

    public float GetLifetime ()
    {
        return lifetime;
    }

}
