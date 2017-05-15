using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{


    private float speed = 1;
    private int speedCount = 0;
    float movePower = 0.2f;

    Rigidbody rd;

    Rect _rect = new Rect(100, 100, 300, 300);


    // Use this for initialization
    void Start()
    {

        rd = GetComponent<Rigidbody>();

    }




    // Update is called once per frame
    void Update()
    {

        //A Dで移動
        Input.GetAxis("Horizontal");
        //this.transform.Rotate(0, Input.GetAxis("Horizontal") * 1 ) 0);

        //Playerの自動移動
        this.transform.Rotate(Time.deltaTime, speed, 0, 0);



        //矢印キーでスピード制御
        /*if (Input.GetKey("right"))
          {
              speed = 0.5f;
          }
          if (Input.GetKey("left"))
          {
              speed = 1f;
          }*/


    }

        }






