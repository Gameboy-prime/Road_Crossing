using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCal : MonoBehaviour
{
    private Transform player;
    public static float distance;



    // Update is called once per frame
    void Update()
    {
        player = PlayerManager.instance.player.transform;
        distance=Vector3.Distance(player.position, transform.position);



        
    }
}
