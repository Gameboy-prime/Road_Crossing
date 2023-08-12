using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random= System.Random;
using UnityEngine.SceneManagement;

public class DeactivateTerrain : MonoBehaviour
{
    public int value1;
    public int value2;
    private bool check;

   


    private void Start()
    {
        ValueDeterminenant();

    }


    public void Deactivate()
    {
        FindObjectOfType<TerrainCollider>().enabled = false;
    }

    public void ValueDeterminenant()
    {
        Random rad = new Random();
        value1 = rad.Next(1, 7);
        value2 = rad.Next(1, 7);
        //Debug.Log("The Two values are" + value1 + " and" + value2);
    }
}
