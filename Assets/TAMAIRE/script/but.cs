using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class but : MonoBehaviour {
    GameObject Button;
    
    public void clickUI()
    {
        playermove.flgb = true;
    }
   
// Use this for initialization
void Start () {       
        Button = GameObject.FindWithTag("Player");
	}
    void Update()
    {
        playermove.flgb = false;
    }
}
