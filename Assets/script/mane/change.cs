using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change : MonoBehaviour
{


    public Image[] ChangeImage = new Image[4];
    private GameObject aaa;
    int i;
    int cn=0;
    // Use this for initialization
    void Start()
    {
        aaa = GameObject.Find("syunou/blueball");
        // ChangeImage.gameobject.activeInHierarchy(false);
        for (i = 0; i < 4; i++)
        {
            ChangeImage[i].enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        aaa.transform.Rotate(0, 100 * Time.deltaTime, 0);
        if (Input.GetKeyDown("space"))
        {
            cn++;
            for (i = 0; i < 4; i++)
            {
                ChangeImage[i].enabled = true;
            }
        }
        //   change.gameobject.activeInHierarchy(false);
        else if (cn == 2)
        {
            for (i = 0; i < 4; i++)
            {
                ChangeImage[i].enabled = false;
            }
            cn = 0;
        }





    }



    void OnCollisionEnter(Collision col)
    {

       

    }


}
