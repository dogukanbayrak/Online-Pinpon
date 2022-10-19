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

    PhotonSettings photonSettings;

    public string serverName;

    public InputField serverNameInput;

    public int maxPlayer;

    public InputField maxPlayerInput;



    public void SetServerSettings()
    {
        string name;

        serverName = serverNameInput.text;

        name = maxPlayerInput.text;

        Debug.Log(serverName+" "+ name);

        maxPlayer = int.Parse(name);

        Debug.Log(maxPlayer + 3); //int maxPlayer check

        

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
