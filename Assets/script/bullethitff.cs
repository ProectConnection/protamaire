using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullethitff : MonoBehaviour {
    public GameObject[] bullethits = new GameObject[3];//0は赤,1は青,2は黄色
    public static bool hitflg;
    int ii;
    int cntt;
    // Use this for initialization
    void Start () {
        hitflg = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
        void OnTriggerEnter(Collider collision)
    {
        Debug.Log("hit"); 
        GameObject[] ff = GameObject.FindGameObjectsWithTag("ball");
        //Destroy(collision.gameObject);
        if (collision.transform.tag == "Player" && playermove.bulletcnt < 5)
        {
            for (ii = playermove.i, cntt = 0; cntt < 5; ii++, cntt++)
            {
                    if (ii >= 5)
                    {
                        ii = 0;
                    }
                    if (playermove.axes[ii] == 0)
                    {
                    
                        playermove.axes[ii] = 1;
                        playermove.bulletcnt++;
                        break;
                    }
            }

            hitflg = true;
            foreach (GameObject bulletfld in ff)
            {
                GameObject.Destroy(bulletfld);
            }
            

           // Debug.Log(playermove.ycnt);

        }
    }
}
