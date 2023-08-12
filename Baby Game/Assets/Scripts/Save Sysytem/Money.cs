using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    public float money;
    

    public void SaveProgress()
    {
        SaveSystem.SaveMoney(this);
    }

    public void LoadProgress()
    {
        MoneyData data = SaveSystem.LoadSystem();
        money = data.cash;
    }

    public void MoneyIncrement()
    {
        money += Statistics.totalValue;
    }
}
