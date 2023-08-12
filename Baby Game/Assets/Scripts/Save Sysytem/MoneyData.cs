using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class MoneyData
{
    public float cash;
    public MoneyData(Money money)
    {
        cash = money.money;

    }
}
