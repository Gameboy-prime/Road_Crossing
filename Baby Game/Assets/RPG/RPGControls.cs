using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RPGControls : MonoBehaviour
{
    
    public Camera cam;
    
    
    
    
    //References 

    public RPGMotor motor;
    
    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
        //If the left Mouse Key is Pressed
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            //Move TO a Position
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit rayHit, 1000))
            {
                motor.MoveTo(rayHit.point);
                
            }
        }
        
        //if the right mouse Key is pressed
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            // if it is an interacteable, we focus on it

            Ray ray1 = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray1, out RaycastHit rayHit1, 100))
            {
                
            }
        }
        
    }
}
