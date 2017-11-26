using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSelectorManager : MonoBehaviour {

    public static int selector;
    public List<string> names;
    public Text nameText;

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

        if (selector == 0)
        {
            nameText.text = names[0];
            selector++;
        }
        else if (selector == 1)
        {
            nameText.text = names[1];
            if (names.Count > 2)
            {
                selector++;
            }
            else
            {
                selector = 0;
            }
        }
        else if (selector == 2)
        {
            nameText.text = names[2];
            if (names.Count > 3)
            {
                selector++;
            }
            else
            {
                selector = 0;
            }
        }
        else if (selector == 3)
        {
            nameText.text = names[3];
            selector = 0;
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onReturnButtonPress()
    {
        SceneManager.LoadScene(3);
    }
}
