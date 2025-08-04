using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelCollider frontRightWheelCollider;
    public WheelCollider frontLeftWheelCollider;
    public WheelCollider backRightWheelCollider;
    public WheelCollider backLeftWheelCollider;

    public Transform frontRightWheelTransform;
    public Transform frontLeftWheelTransform;
    public Transform backRightWheelTransform;
    public Transform backLeftWheelTransform;
    public Transform carCenterOfMass;

    private Rigidbody rigidbody;

    public float motorForce = 200f;
    public float steeringAngle = 30f;
    public float breakForce = 1000f;
    float verticalInput;
    float horizontalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.centerOfMass = carCenterOfMass.localPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MotorForce();
        UpdateWheel();
        GetInput();
        Steering();
        applyBreak();
        CarSpeed();
    }

    void GetInput()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
    }

    void applyBreak()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            frontLeftWheelCollider.brakeTorque = breakForce;
            frontRightWheelCollider.brakeTorque = breakForce;
            backLeftWheelCollider.brakeTorque = breakForce;
            backRightWheelCollider.brakeTorque = breakForce;
            rigidbody.linearDamping = 1f;
        }
        else
        {
            frontLeftWheelCollider.brakeTorque = 0;
            frontRightWheelCollider.brakeTorque = 0;
            backLeftWheelCollider.brakeTorque = 0;
            backRightWheelCollider.brakeTorque = 0;
            rigidbody.linearDamping = 0f;
        }
    }
    void MotorForce()
    {
        frontRightWheelCollider.motorTorque = motorForce * verticalInput;
        frontLeftWheelCollider.motorTorque = motorForce * verticalInput;
    }

    void Steering()
    {
        frontLeftWheelCollider.steerAngle = steeringAngle * horizontalInput;
        frontRightWheelCollider.steerAngle = steeringAngle * horizontalInput;
    }

    void UpdateWheel()
    {
        RotateWheel(frontRightWheelCollider, frontRightWheelTransform);
        RotateWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        RotateWheel(backRightWheelCollider, backRightWheelTransform);
        RotateWheel(backLeftWheelCollider, backLeftWheelTransform);
    }

    void RotateWheel(WheelCollider wheelCollider, Transform transform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        transform.position = pos;
        transform.rotation = rot;
    }

    public float CarSpeed()
    {
        float speed = rigidbody.linearVelocity.magnitude * 2.23693629f;
        return speed;
    }
}
