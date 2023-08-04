using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGCameraContoller : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    private float currentZoom=1;
    public float minZoom=5;
    public float maxZoom=15;
    public float zoomSpeed = 5f;
    public float pitch = 2f;
    private float panAround;
    public float panAroundSpeed = 5f;

    private void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed *Time.deltaTime;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
        panAround -= Input.GetAxis("Horizontal")* panAroundSpeed*Time.deltaTime;



    }

    private void LateUpdate()
    {
        transform.position = player.position + offset * currentZoom;
        transform.LookAt(player.position + Vector3.up *pitch);
        transform.RotateAround(player.position, Vector3.up, panAround);
        
    }
}
