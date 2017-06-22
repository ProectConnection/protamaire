using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

    

    public Sprite NN;
    public Sprite Red;
    public Sprite Blue;
    public Sprite Yellow;


    Image item_now;


    private bool Item_Flg1;
    private bool Item_Flg2;
    private bool Item_Flg3;

    // Use this for initialization
    void Start()
    {
        item_now = gameObject.GetComponent<Image>();

        Item_Flg1 = false;
        Item_Flg2 = false;
        Item_Flg3 = false;

    }

    // Update is called once per frame
    void Update()
    {




    }




    public void RedBall()
    {

        Item_Flg1 = true;

        Debug.Log("....R");

        if (Item_Flg1 == true)
        {
            item_now.sprite = Red;
        }





    }




    public void BlueBall()
    {



        Item_Flg2 = true;
        Debug.Log("....B");

        if (Item_Flg2 == true)
        {
            item_now.sprite = Blue;
        }

    }







    public void YellowBall()
    {


        Item_Flg3 = true;
        Debug.Log("....Y");

        if (Item_Flg3 == true)
        {
            item_now.sprite = Yellow;
        }



    }





































}
