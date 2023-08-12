using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class VehicleSpawn : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public Transform spawnPoint;
    
    private Transform referencePoint;

    private float distance;
    public float verticalDistance;

    private Transform playerPos;
    
    private bool isInvoke;

    private float milCount;

    private float secCount;

    private int determinant=1;
    // Start is called before the first frame update
    void Start()
    {
        
        referencePoint = PosManager.instance.pos.transform;
        playerPos = PlayerManager.instance.player.transform;
       
        
    }

    private void Update()
    {
        
        verticalDistance = playerPos.position.z- transform.position.z;
        if (verticalDistance < 70 && verticalDistance > -70)
        {
            isInvoke=true;
        }
        else
        {
            isInvoke = false;
        }

        if (isInvoke)
        {
            milCount += Time.deltaTime * 10;
            if (milCount > 10)
            {
                milCount = 0;
                secCount += 1;
                
                
                if (secCount > determinant)
                {
                    Random random = new Random();
                    determinant=random.Next(2, 6);
                    SpawnCar();
                    //Debug.Log(determinant);
                    secCount = 0;
                }
            }



        }

        

    }


    private GameObject Spawn()

    {
        GameObject car = car1;
        Random rad = new Random();
        int value = rad.Next(1, 4);
        if (value == 1)
        {
            car = car1;

        }
        if (value == 2)
        {
            car = car2;

        }
        if (value == 3)
        {
            car = car3;

        }
        

        return car;

    }

    private void  SpawnCar()
    {
        GameObject spawnee = Spawn();
        distance = transform.position.x - referencePoint.position.x;

        
        if (distance >0 )
        {
            GameObject obj=Instantiate(spawnee, spawnPoint.position, Quaternion.Euler(new Vector3(0,-90,0)));
            Destroy(obj, 30);

        }
        else
        {
            GameObject obj1= Instantiate(spawnee, spawnPoint.position, Quaternion.Euler(new Vector3(0,90,0)));
            Destroy(obj1,30);
            
        }

        
       
        //Debug.Log("The VErtical Distance is " + verticalDistance);




    }

    

    
    
}
