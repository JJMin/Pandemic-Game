using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player{
    public string userName;
    public string IPaddress;
    public string password;


   public Player(string userName,string password) {
        this.userName = userName;
        this.password = password;
    }
}
