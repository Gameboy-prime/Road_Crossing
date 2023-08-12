using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;

public class MissionComp : MonoBehaviour
{
    public Money cash;
    public Statistics statistic;
    
    private string moneyDisplay;

    [SerializeField] private TextMeshProUGUI moneyValueBox;
    
    private void Update()
    {
        cash.LoadProgress();
        moneyDisplay = cash.money.ToString("f0");
        moneyValueBox.GetComponent<TextMeshProUGUI>().text = "" + moneyDisplay + ".";
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            statistic.ShowStat();
            cash.MoneyIncrement();
            cash.SaveProgress();
            //cash.LoadProgress();
            
            
        }
    }


    
}
