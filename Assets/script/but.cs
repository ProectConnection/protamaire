using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class but : MonoBehaviour {
    GameObject Button;
    
	// Use this for initialization
	void Start () {

        //Button = GameObject.Find("Button");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(playermove.flgb);
            playermove.flgb = true;  
        }
        else
        {
            playermove.flgb = false;
        }
	}
}
