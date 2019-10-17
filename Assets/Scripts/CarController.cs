//using system.collections;
//using system.collections.generic;
//using unityengine;

//public class CarController : monobehaviour
//{
//    public void getinput()
//    {
//        m_horizontalinput = input.getaxis("horizontal");
//        m_verticalinput = input.getaxis("vertical");
//    }

//    private void steer()
//    {
//        m_steerangle = maxsteerangle * m_horizontalinput;
//        frontdriverw.steerangle = m_steerangle;
//        frontpassengerw.steerangle = m_steerangle;

//    }

//    private void accelerate()
//    {
//        frontdriverw.motortorque = m_verticalinput * motorforce;
//        frontpassengerw.motortorque = m_verticalinput * motorforce;
//    }

//    private void updatewheelposes()
//    {
//        updatewheelpose(frontdriverw, frontdrivert);
//        updatewheelpose(frontpassengerw, frontpassengert);
//        updatewheelpose(backdriverw, backdrivert);
//        updatewheelpose(backpassengerw, backpassengert);
//    }

//    private void updatewheelpose(wheelcollider _collider, transform _transform)
//    {
//        vector3 _pos = _transform.position;
//        quaternion _quat = _transform.rotation;

//        _collider.getworldpose(out _pos, out _quat);

//        _transform.position = _pos;
//        _transform.rotation = _pos;
//    }

//    private void fixedupdate()
//    {
//        getinput();
//        steer();
//        accelerate();
//        updatewheelposes();

//    }

//    private float m_horizontalinput;
//    private float m_verticalinput;
//    private float m_steerangle;

//    public wheelcollider frontdriverw, frontpassengerw;
//    public wheelcollider backdriverw, backpassengerw;
//    public transform frontdrivert, frontpassengert;
//    public transform backdrivert, backpassengert;
//    public float maxsteerangle = 30;
//    public float motorforce = 50;

//    //start is called before the first frame update
//   void start()
//    {

//    }

//    //update is called once per frame
//  void update()
//    {

//    }
//}
