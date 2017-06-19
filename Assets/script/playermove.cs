using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playermove : MonoBehaviour
{ 
    //弾のオブジェクト、弾数
    public GameObject bullet;//弾のオブジェクト
    public GameObject bullet2;//弾のオブジェクト
    public GameObject bullet3;//弾のオブジェクト
    public static float bulletcnt;//弾の所持数
   
    //配列
    private static GameObject[] ren = new GameObject[5];
    public static int i,j;
    public static int[] axes = new int[5];
    //スコアのテキスト
    public Text redtext;
    public static int rscore = 0;
    public Text bluetext;
    public static int bscore = 0;
    public  Text yellowtext;
    public static int yscore = 0;

    public static bool flgb;
    // Use this for initialization
    void Start()
    {
        i = 0;
        //j = 0;
        bulletcnt = 0;//バレット数の初期化
        redtext.text = "redscore:0";
        bluetext.text = "bluescore:0";
        yellowtext.text = "yellowscore:0";
        flgb = false;
    }
    // Update is called once per frame
    void Update()
    {

        redtext.text = "Redscore:" + rscore.ToString();
        bluetext.text = "Bluescore:" + bscore.ToString();
        yellowtext.text = "Yellowscore:" + yscore.ToString();
        float dx = Input.GetAxis("Horizontal");//左右の移動
        float dz = Input.GetAxis("Vertical");//前後の移動
        transform.Translate(dx, 0.0F, dz);//transformのxとzで移動
        float ry = Input.GetAxis("Fire1");//左右矢印でカメラの移動
        transform.Rotate(0.0F, ry, 0.0F);//物体を左右に動かして移動
        Vector3 trans;
        trans = new Vector3(Mathf.Sin(this.transform.localEulerAngles.y * 3.14f / 180) * 80.0f, 80, Mathf.Cos(this.transform.localEulerAngles.y * 3.14f / 180) * 40.0f);
        GameObject rbal = GameObject.Find("");
        Vector3 pow = new Vector3(transform.position.x + trans.x / 180, transform.position.y, transform.position.z + trans.z / 30);
        if (bulletcnt >= 1 && Input.GetKeyDown("space")||bulletcnt>=1&&flgb==true)//spaceでバレットを発射||bulletcnt>=1 && GameObject.FindGameObjectsWithTag("UIbulet")
        {
            Debug.Log(axes[i]);
            if (axes[i] != 0)
            {
                switch (axes[i])
                {
                    case 1:
                        
                        rbal = (GameObject)Instantiate(bullet, pow, this.transform.rotation);
                        break;
                    case 2:
                      
                        rbal = (GameObject)Instantiate(bullet2, pow, this.transform.rotation);
                        break;
                    case 3:
                       
                        rbal = (GameObject)Instantiate(bullet3, pow, this.transform.rotation);
                        break;
                    default:
                        break;
                }
                
                axes[i] = 0;
                i++;
                if (i >= 5)
                {
                    i = 0;
                }
                trans.x *= 1.5f;
                trans.y *= 2.25f;//ここをいじることで軌道が大きくなる
                trans.z *= 2.5F;
                rbal.GetComponent<Rigidbody>().AddForce(trans * 2, ForceMode.Force);
           
                bulletcnt--;
            }
        }
     
    }
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("hit");
        GameObject[] ff = GameObject.FindGameObjectsWithTag("Blueball");
        //Destroy(collision.gameObject);
        if (collision.transform.tag == "Player" && playermove.bulletcnt < 5)
        {
            /* for (ii = playermove.i, cntt = 0; cntt < 5; ii++, cntt++)
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
             {*/
            foreach (GameObject Blueball in ff)
            {
                GameObject.Destroy(Blueball);
            }
            //}


            // Debug.Log(playermove.ycnt);

        }
    }
}