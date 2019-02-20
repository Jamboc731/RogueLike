using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy : Entity {


    public override void Player(int Health)
    {
        base.Player(Health);
        Health = 100;
    }

    public override void Damage(int damage)
    {
        base.Damage(damage);
        damage = 50;
    }
}
