﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yHIT : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collision)
    {
        //Destroy(collision.gameObject);
        if (collision.transform.tag == "kago")
        {
            Destroy(this.gameObject);
            playermove.yscore += 10;
        }

    }
}
