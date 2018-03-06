using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCanvasManager : MonoBehaviour {

    public static MainCanvasManager Instance;

    
    public LobbyCanvas _lobbycanvas;
   

    void Awake() {
        Instance = this;
    }
}
