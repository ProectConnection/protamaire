using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class maneger : MonoBehaviour {
    public enum Player
    {
        MOVE,
        HIT,
        SHOT,
        Score
    }
    public enum Item
    {
        redb,
        blueb,
        yellowb
    }
    public Player player;
    public Item item;
    private int Itemscore;
    public Text redbText;
    private int redbscore;
    public Text bluebText;
    private int bluebscore;
    public Text yellowbText;
    private int yellowbscore;
    // Use this for initialization
    void Start () {
        redbText.text = "" + 0;
        bluebText.text = "" + 0;
        yellowbText.text = "" + 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void redb()
    {
        redbscore++;
        redbText.text = "" + redbscore;
    }
    public void blueb()
    {
        bluebscore++;
        bluebText.text = "" + bluebscore;
    }
    public void yellowb()
    {
        yellowbscore++;
        yellowbText.text = "" + yellowbscore;
    }
}
