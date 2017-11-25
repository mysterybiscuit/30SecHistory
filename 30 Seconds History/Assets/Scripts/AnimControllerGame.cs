using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControllerGame : MonoBehaviour {

    public Animator anim;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void onStartButtonPressed()
    {
        anim.Play("MenuToGame-Game");
    }
}
