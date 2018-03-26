using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//挂在uiroot/newgamescreen上
public class CreateRoom : MonoBehaviour {
    public RoomLayOutGroup eee;

    [SerializeField]
    private UIInput _roomName;//会在面板上显示由于serializefiled之后把UIInput拖进去，也就是说用户输入的房间名字会直接给这个变量
    private UIInput RoomName {
        get { return _roomName; }
    }

    //当点击创建房间按钮时
    public void OnClickCreateRoomBtn() {

        GameSetting gamesetting = GameObject.Find("DDOL/gamesetting").GetComponent<GameSetting>();
       
        int noPlayers=int.Parse(transform.Find("NoPlayers/popup/Label").GetComponent<UILabel>().text);
        int noEPcards=int.Parse(transform.Find("EPcards/popup/Label").GetComponent<UILabel>().text);
        Chanllenge chanllenges=GetComponentInChildren<chanllangeChcekBox>().GetCheckStatus();

        gamesetting.updateGameSetting(noPlayers, noEPcards, chanllenges);

        Application.LoadLevel("MainGame");
        
        //建立一个room 名字为roomname
        RoomOptions roomOptions = new RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = 4 };

        if (PhotonNetwork.CreateRoom(RoomName.value,roomOptions,TypedLobby.Default))
        {
            print("create room successfully sent");//创建房间成功
        }
        else {
            print("create room failed to send");//创建房间失败
        }
        
    }

    //内建当创建房间失败时系统调用
    private void OnPhotonCreateRoomFailed(object[] codeAndMessage) {
        print("Create room failed" + codeAndMessage[1]);
    }
    //内建当创建房间成功时系统调用
    private void OnCreatedRoom() {
        print("Create room success!");
       
    }
}
