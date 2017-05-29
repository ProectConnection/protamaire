using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour {
    public GameObject[] gui=new GameObject[5];//弾のオブジェクト
    // Use this for initialization
    void Start () {
        Vector3 aa=new Vector3(2,3,0);
        for (int i = 0; i < 5; i++)
        {
            Instantiate(gui[i], aa, Quaternion.identity); 
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
