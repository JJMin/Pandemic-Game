using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//挂在lobby上
public class LobbyCanvas : MonoBehaviour {
    [SerializeField]
    private RoomLayOutGroup _roomLayoutGroup;
    private RoomLayOutGroup RoomLayoutGroup {
        get { return _roomLayoutGroup; }
    }
    public void OnClickJoinRoom(string roomName) {
        PhotonNetwork.JoinRoom(roomName);

    }
}
