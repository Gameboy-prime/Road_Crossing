using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    [SerializeField]
    private GameObject player;
    public Statistics stat;
    public Money money;



    

    public void GameIsOver()
    {
        player.GetComponent<Movement>().enabled= false;
        stat.ShowStat();
        money.LoadProgress();
        money.SaveProgress();
    }
}
