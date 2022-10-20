using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
using UnityEngine.UI;


public class PhotonSettings : MonoBehaviourPunCallbacks
{

    public int randomPosition;

    CameraFollow cameraFollow;

    [SerializeField] private GameObject menuScreen;

    public MainMenu mainMenu;

    public bool listCheck=false;
    


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
        //PhotonNetwork.JoinOrCreateRoom("oda", new RoomOptions { MaxPlayers = 3, IsOpen = true, IsVisible = true }, TypedLobby.Default);
        PhotonNetwork.JoinOrCreateRoom(mainMenu.serverName, new RoomOptions { MaxPlayers = (byte)mainMenu.maxPlayer, IsOpen = true, IsVisible = true }, TypedLobby.Default);
        menuScreen.gameObject.SetActive(false);

        mainMenu.maxPlayerList.Add(mainMenu.maxPlayer);
        mainMenu.serverNameList.Add(mainMenu.serverName);

        listCheck = true;
    }



    public override void OnJoinedRoom()
    {
        Debug.Log("Joined room");

        //Debug.Log(mainMenu.maxPlayer + "joined max playerrrr");

        //Debug.Log(PhotonNetwork.CurrentRoom.Name);

        
        //Debug.Log(mainMenu.maxPlayerList[0]);
        //Debug.Log(mainMenu.serverNameList[0]);


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
        Debug.Log("hata ayýklama");
        
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
