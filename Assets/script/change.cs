using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change : MonoBehaviour
{


    public Image ChangeImage = null;


    // Use this for initialization
    void Start()
    {
        // ChangeImage.gameobject.activeInHierarchy(false);
        ChangeImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //   change.gameobject.activeInHierarchy(false);






    }



    void OnCollisionEnter(Collision col)
    {

       

    }


}
