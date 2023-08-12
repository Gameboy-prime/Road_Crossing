using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameOver gameOver;

    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.CompareTag("car"))
        {
            Rigidbody point = other.rigidbody;
            Destroy(point.gameObject);
        }
        else if(other.collider.CompareTag("Player"))
        {
            gameOver.GameIsOver();
            
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
            gameOver.GameIsOver();
        }

    }


}
