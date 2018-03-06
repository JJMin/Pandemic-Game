using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//挂在lobby/GameBar/Grid上
public class RoomLayOutGroup : MonoBehaviour {
    [SerializeField]
    private GameObject _roomListingPrefab;
    private GameObject RoomListingPrefab {
        get { return _roomListingPrefab; }
    }
    private List<RoomListing> _roomListingButtons = new List<RoomListing>();
    private List<RoomListing> RoomListingButtons {
        get { return _roomListingButtons; }
    }

    //内建函数 当房间数目变更时调用
    private void OnReceivedRoomListUpdate() {
       
        RoomInfo[] rooms = PhotonNetwork.GetRoomList();//获取所有room
      
        foreach(RoomInfo room in rooms){
            
            RoomReceived(room);
        }
        RemoveOldRooms();
    }
    public GameObject create() {
        GameObject roomItem = NGUITools.AddChild(this.gameObject, RoomListingPrefab);

        this.GetComponent<UIGrid>().AddChild(roomItem.transform);//新加入一个房间
        return roomItem;
    }

    private void RoomReceived(RoomInfo room) {
        
        int index = RoomListingButtons.FindIndex(x => x.RoomName == room.Name);
        //room不存在 index=-1
        if (index == -1)
        {
            if (room.IsVisible && room.PlayerCount < room.MaxPlayers)
            {

                GameObject roomItem=create();
                
                RoomListing rlScripts = roomItem.GetComponent<RoomListing>();
                RoomListingButtons.Add(rlScripts);//把新房间上的脚本


                index = RoomListingButtons.Count - 1;//更新新创建房间的index为最后一个
            }
        }
       if(index!=-1){
            //获取已存在的房间脚本
            RoomListing roomListing = RoomListingButtons[index];
            roomListing.SetRoomNameText(room.Name);
            roomListing.Updated = true;
        }
        
    }
    private void RemoveOldRooms() {
        List<RoomListing> removeRooms = new List<RoomListing>();//list存要remove的房间们
        foreach(RoomListing roomListing in RoomListingButtons){
            if (!roomListing.Updated)
            {
                removeRooms.Add(roomListing);
            }
            else {
                roomListing.Updated = false;
            }
        }

        foreach(RoomListing roomListing in removeRooms){
            GameObject roomListingObj = roomListing.gameObject;
            RoomListingButtons.Remove(roomListing);
            NGUITools.Destroy(roomListingObj);
        }
    }
}
