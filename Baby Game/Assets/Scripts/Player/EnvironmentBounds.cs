using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentBounds : MonoBehaviour
{
    [SerializeField]
    private float bounds=40f;
    public static bool IsLeftMoveable;
    public static bool IsRightMoveable;
    

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x< bounds)
        {
            IsLeftMoveable = true;
        }
        else
        {
            IsLeftMoveable = false;
        }

        if(transform.position.x > -bounds)
        {
            IsRightMoveable = true;
        }
        else
        {
            IsRightMoveable = false;
        }
        Debug.Log(IsLeftMoveable.ToString() +  IsRightMoveable.ToString());
        
    }


}
