using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    int maxHealth;
    int currentHealth;

    public Health(int _max)
    {
        maxHealth = _max;
        currentHealth = maxHealth;
    }

    public int GetMax()
    {
        return maxHealth;
    }

    public int GetCurrent()
    {
        return currentHealth;
    }

    public void MaxHealth()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int value)
    {
        currentHealth -= value;
    }

    public void HealDamage(int value)
    {
        currentHealth += value;
        if (currentHealth >= maxHealth)
            MaxHealth();
    }

}
