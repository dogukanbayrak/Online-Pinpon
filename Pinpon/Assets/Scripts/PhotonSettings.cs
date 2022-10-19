using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;


public class PhotonSettings : MonoBehaviourPunCallbacks
{

    public int randomPosition;

    CameraFollow cameraFollow;

    [SerializeField] private GameObject menuScreen;

    MainMenu mainMenu;


    void Start()
    {
        Debug.Log("Connecting to server");        
        PhotonNetwork.ConnectUsingSettings();
        
        cameraFollow = FindObjectOfType<CameraFollow>();
        
    }

    
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to server");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined lobby");

        //PhotonNetwork.JoinOrCreateRoom("oda", new RoomOptions { MaxPlayers = 3, IsOpen = true, IsVisible = true }, TypedLobby.Default);
        //PhotonNetwork.JoinRandomRoom();
    }

    public void CreateRoom()
    {
        PhotonNetwork.JoinOrCreateRoom("oda", new RoomOptions { MaxPlayers = 3, IsOpen = true, IsVisible = true }, TypedLobby.Default);
        menuScreen.gameObject.SetActive(false);
    }



    public override void OnJoinedRoom()
    {
        Debug.Log("Joined room");

        CreateCube();
    }

    public override void OnLeftLobby()
    {
        Debug.Log("Leave lobby");
    }

    public override void OnLeftRoom()
    {
        Debug.Log("Leave room");
    }


    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log("Error : Join room failed");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Error : Random room failed");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Error : Create a room failed");
    }

    public void EnterLobby()
    {
        Debug.Log("hata ay�klama");
        
    }

    public void RandomNumberGenerator()
    {
        randomPosition = Random.Range(-10, 20);
    }

    public void CreateCube()
    {
        RandomNumberGenerator();
        GameObject cube = PhotonNetwork.Instantiate("Cube", new Vector3(randomPosition,0,randomPosition), Quaternion.identity, 0, null);
        
        
    }

}
