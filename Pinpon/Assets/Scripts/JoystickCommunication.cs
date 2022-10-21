using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickCommunication : MonoBehaviour
{

    public Joystick joystick;

    public bool verticalCheck;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(joystick.Vertical > 0.1f)
        {
            verticalCheck = true;
        }
        else if (joystick.Vertical < -0.1f)
        {
            verticalCheck = false;
        }

        //if (joystick.Horizontal < -0.2f) { }
        
    }
}
