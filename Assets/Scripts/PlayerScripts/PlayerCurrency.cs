using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCurrency : MonoBehaviour
{

    int money = 0;

    public int GetMoney ()
    {
        return money;
    }

    public void SetMoney (int _money)
    {
        money = _money;
    }

    public void AddMoney (int _money)
    {
        money += _money;
    }

}
