using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletbox : MonoBehaviour {
    public GameObject[] bulletf = new GameObject[3];
    float hitcnt;
	// Use this for initialization
	void Start () {
        hitcnt = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "kago")
        {
            //cnt++;
            Destroy(this.gameObject);
            //Debug.Log(kagocnt);
            playermove.rscore += 10;
        }
    }
}
