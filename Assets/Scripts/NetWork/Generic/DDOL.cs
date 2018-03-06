using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDOL : MonoBehaviour {

    private void Awake() {
        DontDestroyOnLoad(this);//切换场景时不销毁这个脚本挂载的物体以及其子物体
    }
}
