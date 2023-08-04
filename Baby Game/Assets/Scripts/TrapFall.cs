using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class TrapFall : MonoBehaviour
{
    [SerializeField] private int coverValue;
    
    public DeactivateTerrain deactivateTerrain;

    
    
    public VehicleSpawn spawn;

    private float minValue;

    private float secValue;

    private int point1;

    private int point2;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        float distance = spawn.verticalDistance;
        if (distance > -50 && distance < 50)
        {


            minValue += Time.deltaTime * 10;
            if (minValue > 10)
            {
                secValue += 1;
                minValue = 0;
                if (secValue == 1)
                {
                    ChangeColor();
                    secValue = 0;

                }
            }
        }

        point1 = deactivateTerrain.value1;
        point2 = deactivateTerrain.value2;


    }

    
    

    IEnumerator PavementColorChange()
    {
        Color color= new Color();
        color = GetComponent<MeshRenderer>().material.color;
        if (coverValue==point1 ||  coverValue==point2)
        {
            yield return new WaitForSeconds(1f);
            GetComponent<MeshRenderer>().material.color = Color.red;
            yield return new WaitForSeconds(1f);
            GetComponent<MeshRenderer>().material.color = color;
            
        }
    }

    public void ChangeColor()
    {
        StartCoroutine(PavementColorChange());

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            if (coverValue==point1|| coverValue==point2)
            {
                GetComponent<MeshCollider>().enabled = false;
                deactivateTerrain.Deactivate();
            }
           

            
        }

        

    }
}
