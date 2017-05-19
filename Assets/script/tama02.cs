using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tama02 : MonoBehaviour {
    public static bool bflg;
    int bcnt;
    int i;
	// Use this for initialization
	void Start () {
        bflg = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collision)
    {
        //Destroy(collision.gameObject);
        if (collision.transform.tag == "Player" && playermove.bulletcnt < 5)
        {
            bflg = true;
            
            
            for (i = playermove.i, bcnt = 0; bcnt < 5; i++, bcnt++)
            {
                if (i >= 5)
                {
                    i = 0;
                }
                if (playermove.axes[i] == 0)
                {
                    playermove.axes[i] = 2;
                    playermove.bulletcnt++;
                    break;
                }
           
            }
            //playermove.ren = GameObject;
            Destroy(this.gameObject);
            //Debug.Log(playermove.ycnt);

        }
    }
}
