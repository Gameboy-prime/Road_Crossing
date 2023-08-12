using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{


    private void OnCollisionEnter(Collision other)
    {
        if(!other.collider.CompareTag("Enemy"))
        {
            GameObject obj = other.collider.gameObject;
            Destroy(obj);

        }
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (!collision.collider.CompareTag("Enemy"))
        {
            GameObject obj = collision.collider.gameObject;
            Destroy(obj);

        }

    }


}
