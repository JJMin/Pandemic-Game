using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public TweenPosition tweenPosStart;
    public TweenPosition tweenPosLogin;
    public TweenPosition tweenPosReg;
    public GameObject lobby;
    public GameObject NewGameScreen;
    public GameObject LoadGameScreen;
    public void OnClickLoginBtnInStart() {
        tweenPosStart.PlayForward();
        tweenPosLogin.PlayForward();
    }
    public void OnClickRegisterBtnInStart()
    {
        tweenPosStart.PlayForward();
        tweenPosReg.PlayForward();
    }


    public void OnClickBackBtnInLogin() {
        tweenPosStart.PlayReverse();
        tweenPosLogin.PlayReverse();
    }
    public void OnClickLoginBtnInLogin() {
        GetComponentInParent<TweenAlpha>().PlayForward();
        lobby.SetActive(true);
        lobby.GetComponent<TweenAlpha>().PlayForward();
    }
    //设置从lobby退回regin界面为default
    public void SetRegLoginDefault() {
        tweenPosLogin.PlayReverse();
        tweenPosStart.PlayReverse();
    }
    public void OnClickExitBtnInLobby() {
        lobby.GetComponent<TweenAlpha>().PlayReverse();
        SetRegLoginDefault();
        GetComponentInParent<TweenAlpha>().PlayReverse();
    }
    public void OnClickNewGameBtnInLobby() {
        lobby.GetComponent<TweenAlpha>().PlayReverse();
        NewGameScreen.SetActive(true);
        NewGameScreen.GetComponent<TweenAlpha>().PlayForward();
    }
    public void OnClickLoadGameBtnInLobby() {
        lobby.GetComponent<TweenAlpha>().PlayReverse();
        LoadGameScreen.SetActive(true);
        LoadGameScreen.GetComponent<TweenAlpha>().PlayForward();
    }

    public void OnClickBackBtnInReg() {
        tweenPosStart.PlayReverse();
        tweenPosReg.PlayReverse();
    }
    public void OnClickBackBtnInNewGameScreen() {
        NewGameScreen.GetComponent<TweenAlpha>().PlayReverse();
        lobby.GetComponent<TweenAlpha>().PlayForward();
    }
    public void OnClickBackBtnInLoadGameScreen() {
        LoadGameScreen.GetComponent<TweenAlpha>().PlayReverse();
        lobby.GetComponent<TweenAlpha>().PlayForward();
    }
    public void OnClickRegisterBtnInReg()
    {
        tweenPosReg.PlayReverse();
        tweenPosLogin.PlayForward();
    }
   
}
