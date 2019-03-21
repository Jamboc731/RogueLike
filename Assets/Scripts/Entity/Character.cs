using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour, IDamageable
{

    protected Health health;

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
        Debug.Log (string.Format ("Took damage: {0}, new health is: {1}", value, health.GetCurrent()));
    }

    public virtual void Die ()
    {
        throw new NotImplementedException ("It died. but nothing happened");
    }
}
