using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int timeLimit = 30;

    public float timePassed;

    public float timeLeft;

    public float linearInterp = 0;

    public GameObject getRectTrans;

    public Rect rectTrans;

    public Image img;

    public Text timeText;

    public Color beginColor;

    private float widthConstant;

	// Use this for initialization
	void Start () {
        timePassed = 0;
        timeLeft = timeLimit;
        //rectTrans = getRectTrans.GetComponentInChildren<Rect>();
        //widthConstant = rectTrans.xMax - rectTrans.xMin / (30 * 50);
	}
	
    void Update()
    {
        timePassed += Time.deltaTime;
        timeLeft -= Time.deltaTime;
    }

	// Update is called once per frame
	void FixedUpdate () {
        linearInterp = timePassed / timeLimit;
        //rectTrans.xMin += widthConstant;
        img.color = Color.Lerp(beginColor, Color.red, linearInterp);
        timeText.text = timeLeft.ToString("0");
	}
}
