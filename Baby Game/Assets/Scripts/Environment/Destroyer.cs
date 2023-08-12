using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnCollisionEnter(Collision other)
    {
        if(!other.collider.CompareTag("Enemy"))
        {
            GameObject obj = other.collider.gameObject;
            Destroy(obj);

        }
        
    }

    
}
