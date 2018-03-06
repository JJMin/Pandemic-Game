using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameVersion { 
    Pandemic,
    pandemic_otb
}
public enum Chanllenge { 
    V,
    VM,
    VB,
    M,
    B,
    NULL
}
public class room : MonoBehaviour {
    public string roomName;//房间名字
    public int maxPlayers;//最大玩家数量
    public int currentPlayers;//当前玩家数量
    public GameVersion gameVersion = GameVersion.Pandemic;
    public int numberEPcards = 4;
    public Chanllenge chanllenge;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
