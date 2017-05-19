using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tama03 : MonoBehaviour {
    public static bool yflg;
    int i;
    int ycnt;
	// Use this for initialization
	void Start () {
        yflg = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collision)
    {
        //Destroy(collision.gameObject);
        if (collision.transform.tag == "Player" && playermove.bulletcnt < 5)
        {
         
            for (i = playermove.i, ycnt = 0; ycnt < 5; i++, ycnt++)
            {
                if (i >= 5)
                {
                    i = 0;
                }
                if (playermove.axes[i] == 0)
                {
                    playermove.axes[i] = 3;
                    playermove.bulletcnt++;
                    break;
                }
           
            }
            yflg = true;
            Destroy(this.gameObject);

           // Debug.Log(playermove.ycnt);

        }
    }
}
