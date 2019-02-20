using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealerEnemy : Entity {


    public override void Player(int Health)
    {
        base.Player(Health);
        Health = 50;
    }

    public override void Heal(int heal)
    {
        base.Heal(heal);
        heal = 100;
    }
}
