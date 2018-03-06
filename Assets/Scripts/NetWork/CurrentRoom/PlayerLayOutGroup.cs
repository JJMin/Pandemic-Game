using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLayOutGroup : MonoBehaviour {
    public GameObject PlayerListingPrefab;//一个名字预制体 fantasier0619

    public List<PlayerListing> PlayerList = new List<PlayerListing>();

    //photon自带方法，当
    private void OnJoinedRoom() {
        Debug.Log("dddd");
        PhotonPlayer[] photonPlayersArr = PhotonNetwork.playerList;//获取
        for (int i = 0; i < photonPlayersArr.Length;i++ ) {

            PlayerJoinedRoom(photonPlayersArr[i]);
            
        }
    }

    //photon自带方法 当player离开房间
    public void OnPhotonPlayerDisconnected(PhotonPlayer player) {
        PlayerLeftRoom(player);
    }


    //当玩家进入这个房间时
    public void PlayerJoinedRoom(PhotonPlayer player){
        if (player == null) return;

        PlayerLeftRoom(player);

        //实例化名字条
        GameObject playerListItem = NGUITools.AddChild(this.gameObject, PlayerListingPrefab);
        this.GetComponent<UIGrid>().AddChild(playerListItem.transform);
        //更新名字条内容
        PlayerListing playerListing=playerListItem.GetComponent<PlayerListing>();
        playerListing.ApplyPhotonPlayer(player);

        //加入list
        PlayerList.Add(playerListing);
    }
    //当玩家离开这个这个房间时
    public void PlayerLeftRoom(PhotonPlayer player) {
        int index = PlayerList.FindIndex(x => x.photonPlayer == player);//在playerlist中找这个玩家的index
        //如果找到了
        if(index!=-1){
            NGUITools.Destroy(PlayerList[index].gameObject);//销毁这个index对应的脚本的游戏物体
            PlayerList.RemoveAt(index);
        }
    }
    
	
}
