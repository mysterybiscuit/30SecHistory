using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {
    public Text[] nameInputs = new Text[4];

    public void onStartButtonPressed()
    {
        if (nameInputs[0].text != "")
        {
            PlayerPrefs.SetString("P1", nameInputs[0].text);
        }
        if (nameInputs[1].text != "")
        {
            PlayerPrefs.SetString("P2", nameInputs[1].text);
        }
        if (nameInputs[2].text != "")
        {
            PlayerPrefs.SetString("P3", nameInputs[2].text);
        }
        if (nameInputs[3].text != "")
        {
            PlayerPrefs.SetString("P4", nameInputs[3].text);
        }
        SceneManager.LoadScene(2); //Loads the level selector
    }
}
