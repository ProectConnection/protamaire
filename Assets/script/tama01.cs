using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tama01 : MonoBehaviour {
    // Use this for initialization
    int i;
    
    int rcnt;
    public static bool rflg;
    void Start () {
        rflg = false;
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    void OnTriggerEnter(Collider collision)
    {
        //Destroy(collision.gameObject);
        if (collision.transform.tag == "Player"&&playermove.bulletcnt<5 ) 
        {
            rflg = true;
            
            for (i = playermove.i,rcnt=0; rcnt < 5; i++,rcnt++)
            {
              
                    if (i >= 5)
                    {
                        i = 0;
                        
                    }
                    if (playermove.axes[i] == 0 )
                    {
                        playermove.axes[i] = 1;
                        playermove.bulletcnt++;
                        break;
                    }
                
            }
            Destroy(this.gameObject);
           // Debug.Log(playermove.Ecnt);
            
        }
    }
}
