using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playermove : MonoBehaviour
{
    //private GameObject cameraObject;//カメラのオブジェクト
    public GameObject bullet;//弾のオブジェクト
    public static float Ecnt;//弾の所持数
    public Text redtext;
    private int rscore = 0;
    public Text bluetext;
    private int bscore = 0;
    public Text yellowtext;
    private int yscore = 0;
    // Use this for initialization
    void Start()
    {
        Ecnt = 0;//バレット数の初期化
        redtext.text = "redscore:0";
        bluetext.text = "bluescore:0";
        yellowtext.text = "yellowscore:0";
        //cameraObject = GameObject.FindWithTag("MainCamera");

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
        if (Ecnt>=1&&Input.GetKeyDown("space"))//spaceでバレットを発射
        {
            GameObject bal;
            Vector3 pow = new Vector3(transform.position.x + trans.x / 180, transform.position.y, transform.position.z + trans.z / 30);
            bal = (GameObject)Instantiate(bullet, pow, this.transform.rotation);
            trans.x *= 1.5f;
            trans.y *= 2.25f;//ここをいじることで軌道が大きくなる
            trans.z *= 2.5F;
            bal.GetComponent<Rigidbody>().AddForce(trans * 2, ForceMode.Force);
            Ecnt--;
        }
    }
}