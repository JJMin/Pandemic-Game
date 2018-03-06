using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//挂在LoadGameJoinedPlayerItem上即fantasier0619
public class PlayerListing : MonoBehaviour {
    public PhotonPlayer photonPlayer;

    public UILabel PlayerName;

    public void ApplyPhotonPlayer(PhotonPlayer photonPlayer) {

        PlayerName.text = photonPlayer.NickName;
    }


	
}
