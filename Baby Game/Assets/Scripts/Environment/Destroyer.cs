using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{


    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.CompareTag("car"))
        {
            Rigidbody point = other.rigidbody;
            Destroy(point.gameObject);
        }
        else
        {
            return;
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
            return;
        }

    }


}
