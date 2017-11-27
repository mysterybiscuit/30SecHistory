using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

    public List<string> names = new List<string>();

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetString("P1") != "")
        {
            names.Add(PlayerPrefs.GetString("P1"));
        }
        if (PlayerPrefs.GetString("P2") != "")
        {
            names.Add(PlayerPrefs.GetString("P2"));
        }
        if (PlayerPrefs.GetString("P3") != "")
        {
            names.Add(PlayerPrefs.GetString("P3"));
        }
        if (PlayerPrefs.GetString("P4") != "")
        {
            names.Add(PlayerPrefs.GetString("P4"));
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onPlayerSelectorButtonPress()
    {
        SceneManager.LoadScene(5);
    }
}
