using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    

    //public GameObject roomList;

    public GameObject createRoomScreen;

    public GameObject mainMenu;

    public PhotonSettings photonSettings;

    public string serverName;

    public InputField serverNameInput;

    public int maxPlayer;
    public string maxPlayerText;

    public InputField maxPlayerInput;


    public List<int> maxPlayerList;

    public List<string> serverNameList;

    public string serverListServerName;
    public int serverListMaxPlayer;


    public void Start()
    {
        maxPlayerList = new List<int>();
        serverNameList = new List<string>();
    }


    public void Update()
    {
        Debug.Log(serverListMaxPlayer);

        if (photonSettings.listCheck)
        {
            Serverlist();
        }
        
    }

    public void Serverlist()
    {
        for (int i=0; i<=serverNameList.Count; i++)
        {
            serverListServerName = serverNameList[i];
            serverListMaxPlayer = serverName[i];
        }
    }

    public void SetServerSettings()
    {
        
        serverName = serverNameInput.text;

        maxPlayerText = maxPlayerInput.text;
        maxPlayer = int.Parse(maxPlayerText);

        //Debug.Log(serverName+" "+ maxPlayerText);

        //Debug.Log(maxPlayer + 3); //int maxPlayer check

        photonSettings.CreateRoom();
    }




    public void ReturnToMainMenu()
    {
        createRoomScreen.gameObject.SetActive(false);
        
    }


    public void Play()
    {
        
        //photonSettings.Jo
    }

    public void CreateRoom()
    {
        createRoomScreen.gameObject.SetActive(true);
        
    }


    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    public void ScreenClose()
    {
        mainMenu.gameObject.SetActive(false);
    }


}
