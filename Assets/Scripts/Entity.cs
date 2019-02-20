using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {

    [SerializeField]
    private int Health;

    [SerializeField]
    private int damage;

    [SerializeField]
    private int heal;

    public virtual void Player(int Health)
    {
        Health = 100;
    }

    public virtual void Damage(int damage)
    {
        Health -= damage;
    }

    public virtual void Heal(int heal)
    {
        Health += heal;
    }
}
