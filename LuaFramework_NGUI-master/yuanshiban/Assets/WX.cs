using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WX : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick()
    {
        ShareDemo.insitens.OnShareClick();
        Debug.Log("点击分享");
    }
}
