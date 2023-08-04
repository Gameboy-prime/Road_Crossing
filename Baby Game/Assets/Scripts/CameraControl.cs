using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private GameObject camHolder;

    private float cubeX;

    private float cubeY;

    private float cubeZ;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cubeX = camHolder.transform.eulerAngles.x;
        cubeY = camHolder.transform.eulerAngles.y;
        cubeZ = camHolder.transform.eulerAngles.z;
        transform.eulerAngles=new Vector3(cubeX - cubeX, cubeY, cubeZ - cubeZ);

    }
}
