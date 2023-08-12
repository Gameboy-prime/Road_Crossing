using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private float vertical;

    private float horizontal;

    [SerializeField] private float rotSpeed;

    
    
    void Update()
    {
        horizontal = Input.GetAxis("Mouse X") *rotSpeed*Time.deltaTime;
        vertical = Input.GetAxis("Mouse Y");
        Mathf.Clamp(horizontal, -45f, 45f);
        if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.Rotate(Vector3.up*horizontal, Space.World);
            transform.Rotate(Vector3.left*vertical*Time.deltaTime, Space.Self);
            
            
           
        }
        

    }
}
