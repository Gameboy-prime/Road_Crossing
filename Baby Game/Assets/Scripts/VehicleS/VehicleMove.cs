using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMove : MonoBehaviour
{
    [SerializeField] private float moveForce;
    [SerializeField]
    private Rigidbody car;
    
    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider frontRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider;
    [SerializeField] private WheelCollider rearRightWheelCollider;

    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform frontRightWheelTransform;
    [SerializeField] private Transform rearLeftWheelTransform;
    [SerializeField] private Transform rearRightWheelTransform;

    void Start()
    {
        car= GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        Motor();
        UpdateWheel();

    }

    private void Motor()
    {
        car.AddForce(transform.forward* moveForce* Time.deltaTime*500, ForceMode.Force);


    }

    private void UpdateWheel()
    {
        UpdateSingelWheel(frontLeftWheelCollider,frontLeftWheelTransform);
        UpdateSingelWheel(frontRightWheelCollider,frontRightWheelTransform);
        UpdateSingelWheel(rearLeftWheelCollider,rearLeftWheelTransform);
        UpdateSingelWheel(rearRightWheelCollider,rearRightWheelTransform);
        
    }

    private void UpdateSingelWheel(WheelCollider collider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        collider.GetWorldPose(out pos, out rot);
        wheelTransform.position = pos;
        wheelTransform.rotation = rot;

    }
    

}
