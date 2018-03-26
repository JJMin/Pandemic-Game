using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chat : MonoBehaviour {
    private bool isChatBoxShow = false;

    public void OnClickChat() {
        if (!isChatBoxShow)
        {
            GetComponentInChildren<TweenPosition>().PlayForward();
            isChatBoxShow = true;
            transform.Find("ChatLabel").GetComponent<UILabel>().text = "▲";
        }
        else {
            GetComponentInChildren<TweenPosition>().PlayReverse();
            isChatBoxShow = false;
            transform.Find("ChatLabel").GetComponent<UILabel>().text = "▼ Chat ▼";
        }

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
