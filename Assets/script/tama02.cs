using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tama02 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collision)
    {
        //Destroy(collision.gameObject);
        if (collision.transform.tag == "Player" && playermove.bcnt < 5)
        {
            playermove.bcnt++;
            Destroy(this.gameObject);
            Debug.Log(playermove.ycnt);

        }
    }
}
