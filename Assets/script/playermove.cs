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


    int g,h;

    int rcnt;
    int bcnt;
    int ycnt;
    public static bool rflg;
    public static bool bflg;
    public static bool yflg;

    public bool RedFlg;
    public bool BlueFlg;
    public bool YellowFlg;



    GameObject Test;



    // Use this for initialization
    void Start()
    {
        i = 0;
        j = 0;
        bulletcnt = 0;//バレット数の初期化
        redtext.text = "redscore:0";
        bluetext.text = "bluescore:0";
        yellowtext.text = "yellowscore:0";


        rflg = false;
        bflg = false;
        yflg = false;

        RedFlg = false;
        BlueFlg = false;
        YellowFlg = false;


        //Testタグを探す(Testに設定)
        Test = GameObject.FindWithTag("Test");


    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))//スペースキーが押されたら
        {

           


        }





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
        if (bulletcnt >= 1 && Input.GetKeyDown("space"))//spaceでバレットを発射
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
        //Destroy(collision.gameObject);

        if (collision.transform.tag == "Redboll" && playermove.bulletcnt < 5)
        {
            rflg = true;


            Test.SendMessage("RedBall");



            for (i = playermove.i, rcnt = 0; rcnt < 5; i++, rcnt++)
            {

                if (i >= 5)
                {
                    i = 0;

                }
                if (playermove.axes[i] == 0)
                {
                    playermove.axes[i] = 1;
                    playermove.bulletcnt++;
                    break;
                }

            }
            Destroy(collision.gameObject);
            // Debug.Log(playermove.Ecnt);

        }





           

            if (collision.transform.tag == "blue" && playermove.bulletcnt < 5)
            {
                bflg = true;
            Test.SendMessage("BlueBall");

            /*if (Blue.gameObject.activeInHierarchy)
            {
                Blue.gameObject.SetActive(true);
            }
            else
            {
                Blue.gameObject.SetActive(false);
            }*/



            for (i = playermove.i, rcnt = 0; rcnt < 5; i++, rcnt++)
                {

                    if (i >= 5)
                    {
                        i = 0;

                    }
                    if (playermove.axes[i] == 0)
                    {
                        playermove.axes[i] = 1;
                        playermove.bulletcnt++;
                        break;
                    }

                }
                Destroy(collision.gameObject);
                // Debug.Log(playermove.Ecnt);

            
        }


        if (collision.transform.tag == "yellow" && playermove.bulletcnt < 5)
        {
            yflg = true;
            Test.SendMessage("YellowBall");
            for (i = playermove.i, rcnt = 0; rcnt < 5; i++, rcnt++)
            {

                if (i >= 5)
                {
                    i = 0;

                }
                if (playermove.axes[i] == 0)
                {
                    playermove.axes[i] = 1;
                    playermove.bulletcnt++;
                    break;
                }

            }
            Destroy(collision.gameObject);
            // Debug.Log(playermove.Ecnt);

        }









    }


   



}