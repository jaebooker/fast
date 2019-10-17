using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Control : MonoBehaviour
{
    public float MotorForce, SteerForce, BrakeForce;
    public WheelCollider FR_L_Wheel, FR_R_Wheel, RE_L_Wheel, RE_R_Wheel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v;
        float h;

        if (OVRInput.Get(OVRInput.Button.One)==true)
        {
            v = MotorForce;
        }
        else
        {
            v = 0;
        }

        if (OVRInput.Get(OVRInput.Button.Two)==true)
        {
            h = SteerForce;
        }
        else
        {
            h = 0;
        }

        RE_L_Wheel.motorTorque = v;
        RE_R_Wheel.motorTorque = v;

        FR_L_Wheel.steerAngle = h;
        FR_R_Wheel.steerAngle = h;


        if (OVRInput.Get(OVRInput.Button.Three) == true)
        {
            RE_L_Wheel.brakeTorque = BrakeForce;
            RE_R_Wheel.brakeTorque = BrakeForce;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            RE_L_Wheel.brakeTorque = 0;
            RE_R_Wheel.brakeTorque = 0;
        }
        if (OVRInput.Get(OVRInput.Button.One)==false)
        {
            RE_L_Wheel.brakeTorque = BrakeForce;
            RE_R_Wheel.brakeTorque = BrakeForce;
        }
        else
        {
            RE_L_Wheel.brakeTorque = 0;
            RE_R_Wheel.brakeTorque = 0;
        }
    }
}
