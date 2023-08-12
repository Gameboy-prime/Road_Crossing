using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentBounds : MonoBehaviour
{
    [SerializeField]
    private float bounds=40f;
    public static bool IsMoveable;
    

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x< bounds && transform.position.x > -bounds)
        {
            IsMoveable = true;
        }
        else
        {
            IsMoveable = false;
        }
        Debug.Log(IsMoveable);
        
    }


}
