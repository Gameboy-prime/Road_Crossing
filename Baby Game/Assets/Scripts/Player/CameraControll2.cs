using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll2 : MonoBehaviour
{
    public Transform player;

    public Vector3 offset;
    public float pitch = 2f;

    private float currentZoom=0f;

    public float minZoom=5f;
    public float maxZoom=15f;
    private float panAround=1f;
    public float panAroundSpeed=20;
    
    
    void Update()
    {
        //currentZoom -= Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime;
        //currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
        //panAround += Input.GetAxis("Horizontal") * panAroundSpeed*Time.deltaTime;

    }

    private void LateUpdate()
    {
        transform.position = player.position + offset ;
        transform.LookAt(player.position + Vector3.up*pitch);
        //transform.RotateAround(player.position, Vector3.up, panAround);
    }
}
