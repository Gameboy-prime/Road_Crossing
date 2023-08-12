using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    
    public CharacterController controller;
    public AudioSource run;

   
    private float horizontalInput;
    private float verticalInput;
    public float moveForce;
    public float jumpForce;

    [SerializeField] public GameObject groundCheck;

    private bool isGrounded;

    private bool jumpKeyWasPresssed;
    private bool moveKeyWasPressed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();

    }
    

    private void MyInput()
    {

        bool checkLeft = EnvironmentBounds.IsLeftMoveable;
        if (checkLeft && Input.GetKey(KeyCode.LeftArrow))
        {
            controller.Move(Vector3.left*5*moveForce*Time.deltaTime);
        }
        bool checkRIght= EnvironmentBounds.IsRightMoveable;
        if (checkRIght && Input.GetKey(KeyCode.RightArrow))
        {
            controller.Move(Vector3.right * 5 * moveForce * Time.deltaTime);
        }




        if (Input.GetKey(KeyCode.UpArrow))
        {
            controller.Move(Vector3.forward * 5 * moveForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            controller.Move(Vector3.back * 5 * moveForce * Time.deltaTime);
        }
        jumpKeyWasPresssed = Input.GetKeyDown(KeyCode.Space);
        
        /* IF YOU WANT TO CHANGE THE ROTATION OF A BODY TO THAT OF THE CAMERA
        float camX = camera.eulerAngles.x;
        float camY = camera.eulerAngles.y;
        float camZ = camera.eulerAngles.z;
        transform.rotation=Quaternion.Euler(new Vector3(0,camY,0));*/
        
        

    }
     void FixedUpdate()
    {
        
        //body.velocity= transform.right*horizontalInput +new Vector3(0, body.velocity.y,0) + transform.forward*verticalInput;

        
        
        
        if (Physics.OverlapSphere(groundCheck.transform.position,0.1f ).Length == 2)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        if(isGrounded  && jumpKeyWasPresssed)
        {
            //body.AddForce(new Vector3(0,2*jumpForce*Time.deltaTime ,0), ForceMode.Impulse);
        }

        
    }
     

     private void OnDrawGizmosSelected()
     {
         Gizmos.color = Color.red;
         Gizmos.DrawWireSphere(groundCheck.transform.position, 0.1f);
     }
}
