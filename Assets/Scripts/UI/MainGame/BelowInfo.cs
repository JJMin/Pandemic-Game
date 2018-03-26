using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BelowInfo : MonoBehaviour {
    private bool isBelowPanelShown;


    public void OnClickBelowInfo() {
        if (!isBelowPanelShown)
        {
            transform.Find("BelowPanel").GetComponent<TweenPosition>().PlayForward();
            transform.Find("tri").GetComponent<UILabel>().text = "▼                                                                                      ▼";
            isBelowPanelShown = true;

        }
        else {
            transform.Find("BelowPanel").GetComponent<TweenPosition>().PlayReverse();
            transform.Find("tri").GetComponent<UILabel>().text = "▲                                                                                      ▲";
            isBelowPanelShown = false;
        }
       
    }

}
