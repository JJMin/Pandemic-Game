using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BelowInfo : MonoBehaviour {
    private bool isBelowPanelShown;


    public void OnClickBelowInfo() {
        if (!isBelowPanelShown)
        {
            transform.FindChild("BelowPanel").GetComponent<TweenPosition>().PlayForward();
            transform.FindChild("tri").GetComponent<UILabel>().text = "▼                                                                                      ▼";
            isBelowPanelShown = true;

        }
        else {
            transform.FindChild("BelowPanel").GetComponent<TweenPosition>().PlayReverse();
            transform.FindChild("tri").GetComponent<UILabel>().text = "▲                                                                                      ▲";
            isBelowPanelShown = false;
        }
       
    }

}
