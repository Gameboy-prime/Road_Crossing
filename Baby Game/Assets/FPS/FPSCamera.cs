using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{

    public Transform player;

    public float mouseSensitivity = 20f;
    float horizontalX = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")* mouseSensitivity * Time.deltaTime;
       
        
        horizontalX -= mouseY;
        Mathf.Clamp(horizontalX, -90f, 90f);
        transform.localRotation = Quaternion.Euler(horizontalX, 0,0);
        
        
        player.Rotate(Vector3.up*mouseX);
        





    }
}
