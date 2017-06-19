using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour {
    GameObject mainCamera;
    GameObject Button;
    Camera main;
	// Use this for initialization
	void Start () {
        mainCamera = GameObject.Find("Main Camera");
        Button = GameObject.Find("Button");
	}
	
	// Update is called once per frame
	void Update () {
        //カメラを取得
        main = mainCamera.GetComponent<Camera>();
        Vector3 mousePos = main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D col = Physics2D.OverlapPoint(mousePos);
        //タップ確認
        if (Input.GetMouseButtonDown(0))
        {
            if (col == Button.GetComponent<Collider2D>())
            {
                Debug.Log(playermove.flgb);
                playermove.flgb = true;

            }
        }
        else
        {
            playermove.flgb = false;
        }
    }
}
