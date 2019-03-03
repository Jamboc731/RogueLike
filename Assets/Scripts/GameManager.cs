using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    [SerializeField] GameObject player;
    PlayerCurrency pMoney;
    [SerializeField] Text currencyText;

    private void Start ()
    {
        pMoney = player.GetComponent<PlayerCurrency> ();
        UpdateCurrencyText ();
    }

    public void AddMoneyToPlayer(int value)
    {
        pMoney.AddMoney (value);
        UpdateCurrencyText ();
    }

    private void UpdateCurrencyText ()
    {
        currencyText.text = pMoney.GetMoney ().ToString();
    }

}
