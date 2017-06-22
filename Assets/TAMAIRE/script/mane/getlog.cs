using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getlog : MonoBehaviour {
    static private Queue logQueue;
    static private uint iNumLog = 20;
    static public void Init()
    {
        logQueue = new Queue();
        iNumLog = 20;
    }
    static public void PushLog(string str, bool console = false)
    {
        if (logQueue.Count >= iNumLog) logQueue.Dequeue();

        logQueue.Enqueue(str);
        if (console) Debug.Log(str);
    }
    static public void RenderLog(Rect rect, Color color)
    {
        Rect curRect = rect;
        curRect.y += rect.height * (logQueue.Count - 1);
        Color prevColor = GUI.color;
        GUI.color = color;

        System.Collections.IEnumerator ienum = logQueue.GetEnumerator();
        while (ienum.MoveNext())
        {
            GUI.Label(curRect, (string)ienum.Current);
            curRect.y -= rect.height;
        }

        GUI.color = prevColor;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
