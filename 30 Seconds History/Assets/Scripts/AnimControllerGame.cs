using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControllerGame : MonoBehaviour {

    public Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onStartButtonPressed()
    {
        anim.Play("MenuTolevel-Game");
    }

    public void onGameButtonPressed()
    {
        anim.Play("LevelToGame-Game");
    }
}
