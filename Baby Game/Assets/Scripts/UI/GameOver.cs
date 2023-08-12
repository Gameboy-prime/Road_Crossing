using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public MenuManager menu;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            menu.GameIsOver();
        }
        
        
        
    }
}
