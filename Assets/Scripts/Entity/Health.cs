using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    int maxHealth;
    int currentHealth;

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
        if (currentHealth <= 0)
            Die();
    }

    public void HealDamage(int value)
    {
        currentHealth += value;
        if (currentHealth >= maxHealth)
            MaxHealth();
    }

    protected virtual void Die()
    {
        Debug.Log(string.Format("{0} has died.", gameObject.name));
    }

}
