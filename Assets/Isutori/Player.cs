using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    private int speed = 0;
    float movePower = 0.2f;

    Rigidbody rd;

	// Use this for initialization
	void Start () {

        rd = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdata()
    {

        if (Input.GetKey("right"))
        {

            


        }




    }
}
