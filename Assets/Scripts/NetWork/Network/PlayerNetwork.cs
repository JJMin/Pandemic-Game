 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNetwork : MonoBehaviour {
    public static PlayerNetwork Instance;
    public string Playername { get; private set; }


	private void Awake(){
        Instance = this;
        Playername = "bzk" + Random.Range(1000, 9999);
    }
}
