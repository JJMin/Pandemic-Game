using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum cityRegion { 
    blue,
    yellow,
    black,
    red
}

public class City:MonoBehaviour{
    public cityRegion region;
    public UILabel name;
    public List<City> adjacentCityList = new List<City>();

   
}
