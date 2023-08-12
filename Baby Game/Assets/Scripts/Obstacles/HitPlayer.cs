using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour
{


    public GameOver gameOver;
    

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            other.body.GetComponent<Rigidbody>().AddForce(Vector3.right*10, ForceMode.Impulse);
            other.body.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            gameOver.GameIsOver();
        }
       
    }
}
