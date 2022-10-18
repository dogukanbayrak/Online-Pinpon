using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class CubeMovement : MonoBehaviour
{

    public float jumpSpeed, moveSpeed;
    public Rigidbody rb;
    PhotonView pw;
    public Camera mainCam;

    void Start()
    {
        pw = GetComponent<PhotonView>();



        if (!pw.IsMine)
        {
            Destroy(mainCam);
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



        if (Input.GetKey(KeyCode.W) && GetComponent<PhotonView>().IsMine)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) && GetComponent<PhotonView>().IsMine)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) && GetComponent<PhotonView>().IsMine)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) && GetComponent<PhotonView>().IsMine)
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<PhotonView>().IsMine)
        {
            rb.velocity += Vector3.up * jumpSpeed;
        }

    }
}
