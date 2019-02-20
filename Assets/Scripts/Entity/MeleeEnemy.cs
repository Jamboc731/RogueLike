using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : Entity {


    public override void Player(int Health)
    {
        base.Player(Health);
        Health = 200;
    }

    public override void Damage(int damage)
    {
        base.Damage(damage);
        damage = 50;
    }
}
