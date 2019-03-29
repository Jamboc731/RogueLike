using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Character
{

    [SerializeField] int maxHealth;

    private void Update ()
    {
        //Debug.Log (health.GetCurrent ());
    }

    public override void InitHealth ()
    {
        health = new Health (maxHealth);
    }

    public override void Die ()
    {
        Debug.Log ("Player Died");
        Destroy (gameObject);
    }

}
