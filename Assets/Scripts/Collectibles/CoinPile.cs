using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPile : MonoBehaviour, IPickupable {

    [SerializeField] int value;
    GameManager manager;

    private void Start ()
    {
        manager = GameObject.Find ("GameManager").GetComponent<GameManager> ();
    }

    public void Destroy ()
    {
        Destroy (gameObject);
    }

    public void PickedUp ()
    {
        manager.AddMoneyToPlayer (value);
        Destroy ();
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag ("Player"))
        {
            PickedUp ();
        }
    }
}
