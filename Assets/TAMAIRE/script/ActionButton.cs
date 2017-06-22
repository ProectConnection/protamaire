using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionButton : MonoBehaviour {



    GameObject ActionButtonImage;



    //アクションボタンテスト用
    public Text TestText;
    public int TestCnt = 0;




    // Use this for initialization
    void Start()
    {
        ActionButtonImage = GameObject.FindWithTag("Player");




        TestText.text = "TestClickCnt";


    }
    void Update()
    {
        playermove.flgb = false;



        TestText.text = "TestClickCnt" + TestCnt;



    }



    //EventTriggerコンポーネント
    public void ClickAction()
    {
        playermove.flgb = true;

        TestCnt++;

    }




}
