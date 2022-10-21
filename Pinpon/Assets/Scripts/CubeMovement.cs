using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class CubeMovement : MonoBehaviour
{

    //public JoystickCommunication joystickCommunication;

    public Joystick joystick;

    

    public float jumpSpeed, moveSpeed;
    public Rigidbody rb;
    PhotonView pw;
    public Camera mainCam;

    public Canvas canvas;


    void Start()
    {
        pw = GetComponent<PhotonView>();



        if (!pw.IsMine)
        {
            Destroy(mainCam);
            Destroy(canvas);
        }
        if (pw.IsMine)
        {
            GetComponent<Renderer>().material.color = Color.green;
        }


    }

    // Update is called once per frame
    void Update()
    {
        

        Movement();

    }


    public void Movement()
    {



        if (joystick.Vertical > 0.1f && GetComponent<PhotonView>().IsMine)
        {
            Debug.Log("sadasdasdasdas");
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (joystick.Vertical < -0.1f && GetComponent<PhotonView>().IsMine)
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (joystick.Horizontal > 0.1f && GetComponent<PhotonView>().IsMine)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (joystick.Horizontal < -0.1f && GetComponent<PhotonView>().IsMine)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
       
        

        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<PhotonView>().IsMine)
        {
            rb.velocity += Vector3.up * jumpSpeed;
        }

    }
}
