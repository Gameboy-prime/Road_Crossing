using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : MonoBehaviour
{
    public CharacterController control;

    private bool grounded;
    private Vector3 velocity;
    public float acceleration = -9.81f;

    public Transform groundeCheck;

    private float min;

    private float sec;

    public float jumpDistance=3f;

    public float moveForce=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal")*moveForce*Time.deltaTime;
        float vertical = Input.GetAxis("Vertical")*moveForce*Time.deltaTime;
        control.Move(transform.right * horizontal + transform.forward * vertical);
        
       
        //sec = 0;
       
        

        if (Physics.OverlapSphere(groundeCheck.position, 0.4f).Length == 2)
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
        if (grounded==false)
        {
            velocity.y = -2f;
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            velocity.y = Mathf.Sqrt(-2f * (acceleration) * jumpDistance) ;
            
        }

        
       
        velocity.y += acceleration *Time.deltaTime;
        control.Move(velocity * Time.deltaTime);
        //sec = 0;
        Debug.Log(velocity.y);

        
        
        Debug.Log(Physics.OverlapSphere(groundeCheck.position, 0.4f).Length);

        






    }

    

    private void OnDrawGizmosSelected()
    {
        Gizmos.color= Color.red;
        Gizmos.DrawWireSphere(groundeCheck.position, 0.2f);
    }
    
    
}
