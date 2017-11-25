using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int timeLimit = 30;

    public float timeLeft;

    public Image img;

	// Use this for initialization
	void Start () {
        timeLeft = timeLimit;
	}
	
    void Update()
    {
        timeLeft -= Time.deltaTime;
    }

	// Update is called once per frame
	void FixedUpdate () {
        img.color = Color.Lerp(Color.green, Color.red, 0.5f);
	}
}
