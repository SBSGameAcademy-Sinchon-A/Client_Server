using Photon.Pun;
using Photon.Realtime;
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnetServer : MonoBehaviourPunCallbacks
{
    private string gameVersion = "1";
    
    void Awake()
    {
        PhotonNetwork.GameVersion = this.gameVersion;
        PhotonNetwork.ConnectUsingSettings();
    }


    void Update()
    {
        
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Successfully joined the lobby.");

        RoomOptions rm = new RoomOptions();
        rm.MaxPlayers = 2;
        PhotonNetwork.JoinOrCreateRoom("MyRoom", rm, TypedLobby.Default);
    
    }
}
