using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour, IDamageable
{

    Health health;

    private void Start ()
    {
        InitHealth ();
    }

    public virtual void InitHealth ()
    {
        health = new Health (10);
    }

    public void TakeDamage (int value)
    {
        health.TakeDamage (value);
        if(health.GetCurrent() <= 0)
        {
            Die ();
        }
    }

    public virtual void Die ()
    {
        throw new NotImplementedException ("It died. but nothing happened");
    }
}
