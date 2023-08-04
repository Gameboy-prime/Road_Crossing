using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateBoxCollider : MonoBehaviour
{
    IEnumerator OnTriggerEnter(Collider other)
    {
        
        if (other.GetComponent<BoxCollider>().CompareTag("car"))
        {
            
            other.GetComponent<BoxCollider>().enabled=false;
            yield return new WaitForSeconds(3);
            other.GetComponent<BoxCollider>().enabled = true;


        }
        
        
    }

    
}
