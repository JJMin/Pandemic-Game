using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//挂在uiroot/lobby场景
public class LobbyNetwork : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Connecting to Server...");
        PhotonNetwork.ConnectUsingSettings("0.0.0");
	}
    //photon内建方法
    //当连接到服务器成功后
    private void OnConnectedToMaster() {
        print("Connected to master.");
       

        PhotonNetwork.JoinLobby(TypedLobby.Default);//加入lobby
    }
    private void OnJoinedLobby() {
        print("Lobby Joined!");
    }
}
