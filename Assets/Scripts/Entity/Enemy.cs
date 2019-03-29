using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : Character
{

    [SerializeField] EnemySO stats;
    float moveSpeed;
    int damage;
    SpriteRenderer spRend;

    private void Start ()
    {
        Initialise ();
    }

    void Initialise ()
    {
        gameObject.name = stats.name;
        moveSpeed = stats.moveSpeed;
        damage = stats.damage;
        spRend = GetComponent<SpriteRenderer> ();
        spRend.sprite = stats.sprite;
        gameObject.AddComponent<BoxCollider2D> ();
        gameObject.tag = "Enemy";
        InitHealth ();
    }

    public override void InitHealth ()
    {

        health = new Health (stats.maxHealth);
        
    }

    public override void Die ()
    {
        Debug.Log ("Dedded");
        gameObject.SetActive (false);
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        GameObject other = collision.collider.gameObject;
        if (other.CompareTag ("Player"))
        {
            other.GetComponent<PlayerHealth> ().TakeDamage (1);
        }
    }

}
