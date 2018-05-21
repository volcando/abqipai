using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WXclick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnClick()
    {
        Debug.Log("点击分享");
        ShareDemo.SDK.OnShareClick();
        Debug.Log("点击完毕");
    }
}
