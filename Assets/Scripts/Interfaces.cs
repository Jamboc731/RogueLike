using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPickupable 
{

    void PickedUp ();

    void Destroy ();

}

public interface IDamageable
{

    void TakeDamage (int value);

}

public interface IHealable
{

    void HealDamage (int value);

}
