using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Statistics : MonoBehaviour
{
    [SerializeField] private GameObject statBox;
    [SerializeField] private GameObject mainCanvas;
    [SerializeField] private TextMeshProUGUI reward;
    [SerializeField] private TextMeshProUGUI vehiclesDestroyed;
    [SerializeField] private TextMeshProUGUI bonuses;
    [SerializeField] private TextMeshProUGUI total;

    public float rewardValue;
    private float carDestroyedValue=100;
    private float bonusValue;
    public static float totalValue;

    private string rewardDisplay;
    private string carDestroyedDisplay;
    private string bonusDisplay;
    private string totalDisplay;

    private void Start()
    {
        reward = reward.GetComponent<TextMeshProUGUI>();
        vehiclesDestroyed = vehiclesDestroyed.GetComponent<TextMeshProUGUI>();
        bonuses = bonuses.GetComponent<TextMeshProUGUI>();
        total = total.GetComponent<TextMeshProUGUI>();
    }

    public void ShowStat()
    {
        StartCoroutine(Stat());

    }

    IEnumerator Stat()
    {
        
        statBox.SetActive(true);
        mainCanvas.SetActive(false);
        yield return new WaitForSeconds(.5f);
        reward.enabled = true;
        rewardDisplay = rewardValue.ToString("f0");
        float count = 0f;
        while (count<rewardValue+1)
        {
            
            reward.text = "" + count.ToString("f0") + ".";
            
            count += 1;
            Debug.Log(count);

        }

        
        
        
        yield return new WaitForSeconds(.3f);
        vehiclesDestroyed.enabled=true;
        carDestroyedDisplay=carDestroyedValue.ToString("f0");
        float count2 = 0f;
        while (count2 < carDestroyedValue+1)
        {
            
            vehiclesDestroyed.text = "" + count2.ToString("f0") + ".";
            count2 += 1;
            Debug.Log(count2);
            
        }

        
        
        
        yield return new WaitForSeconds(.3f);
        bonuses.enabled = true;
        bonusValue = (rewardValue + carDestroyedValue)/10;
        float count3 = 0f;
        while (count3<bonusValue+1)
        {
            bonuses.text = "" + count3.ToString("f0") + ".";
            count3 += 1;
            Debug.Log(count3);
            
        }
        bonusDisplay=bonusValue.ToString("f0");
        
        
        yield return new WaitForSeconds(.3f);
        total.enabled = true;
        totalValue = rewardValue + carDestroyedValue + bonusValue;
        float count4 = 0f;
        while (count4<totalValue+1)
        {
            total.text = "" + count4.ToString("f0") + ".";
            count4 += 1;
            Debug.Log(count4);
        }
        totalDisplay=totalValue.ToString("f0");


    }
}
