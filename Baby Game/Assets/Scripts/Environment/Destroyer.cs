using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public Statistics stat;
    public Money money;

    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.CompareTag("car"))
        {
            Rigidbody point = other.rigidbody;
            Destroy(point.gameObject);
        }
        else if(other.collider.CompareTag("Player"))
        {
            stat.ShowStat();
            money.SaveProgress(); 
            money.LoadProgress(); 
            
        }
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.rigidbody.CompareTag("car"))
        {
            Rigidbody point = collision.rigidbody;
            Destroy(point.gameObject);
            

        }
        else
        {
            stat.ShowStat();
            money.SaveProgress();
            money.LoadProgress();
        }

    }


}
