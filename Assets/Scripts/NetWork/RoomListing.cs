using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//挂在lobbyGameItem上
public class RoomListing : MonoBehaviour {
    [SerializeField]
    private UILabel _roomNameText;
    private UILabel RoomNameText {
        get { return _roomNameText; }
    }
    public string RoomName;
    public bool Updated { get; set; }

	// Use this for initialization
	void Start () {
        
	}
    //当点击这个房间时，调用lobbycanvas上的onclickjoinroom方法，传参这个点击房间的名字
    public void OnClickJoinGameBtn() {
        //当未加入该游戏时......
        MainCanvasManager.Instance.GetComponentInChildren<LobbyCanvas>().OnClickJoinRoom(RoomNameText.text);
        //TODO当已加入该游戏
    }

    public void SetRoomNameText(string text) {
        RoomName = text;
        RoomNameText.text = RoomName;
    }
	
}
