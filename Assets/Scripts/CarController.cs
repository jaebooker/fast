using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public void getinput()
    {
        m_horizontalinput = Input.GetAxis("Horizontal");
        m_verticalinput = Input.GetAxis("Vertical");
    }

    private void steer()
    {
        m_steerangle = maxsteerangle * m_horizontalinput;

        frontdriverw.steerAngle = m_steerangle;
        frontpassengerw.steerAngle = m_steerangle;

    }

    private void accelerate()
    {
        frontdriverw.motorTorque = m_verticalinput * motorforce;
        frontpassengerw.motorTorque = m_verticalinput * motorforce;
    }

    private void updatewheelposes()
    {
        updatewheelpose(frontdriverw, frontdrivert);
        updatewheelpose(frontpassengerw, frontpassengert);
        updatewheelpose(backdriverw, backdrivert);
        updatewheelpose(backpassengerw, backpassengert);
    }

    private void updatewheelpose(WheelCollider _collider, Transform _transform)
    {
        Vector3 _pos = _transform.position;
        Quaternion _quat = _transform.rotation;

        _collider.GetWorldPose(out _pos, out _quat);

        _transform.position = _pos;
        _transform.rotation = _quat;
    }

    private void FixedUpdate()
    {
        getinput();
        steer();
        accelerate();
        updatewheelposes();

    }

    private float m_horizontalinput;
    private float m_verticalinput;
    private float m_steerangle;

    public WheelCollider frontdriverw, frontpassengerw;
    public WheelCollider backdriverw, backpassengerw;
    public Transform frontdrivert, frontpassengert;
    public Transform backdrivert, backpassengert;
    public float maxsteerangle = 300;
    public float motorforce = 500;

}
