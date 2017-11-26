using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public Toggle[] CheckBoxes = new Toggle[10];

    public void startButtonPressed()
    {
        checkCheckBoxes();
        SceneManager.LoadScene(5);
    }

    public void checkCheckBoxes()
    {
        if (CheckBoxes[0].isOn)
        {
            PlayerPrefs.SetInt("TV1", 1);
        }
        else
        {
            PlayerPrefs.SetInt("TV1", 0);
        }

        if (CheckBoxes[1].isOn)
        {
            PlayerPrefs.SetInt("TV2", 1);
        }
        else
        {
            PlayerPrefs.SetInt("TV2", 0);
        }

        if (CheckBoxes[2].isOn)
        {
            PlayerPrefs.SetInt("TV3", 1);
        }
        else
        {
            PlayerPrefs.SetInt("TV3", 0);
        }

        if (CheckBoxes[3].isOn)
        {
            PlayerPrefs.SetInt("TV4", 1);
        }
        else
        {
            PlayerPrefs.SetInt("TV4", 0);
        }

        if (CheckBoxes[4].isOn)
        {
            PlayerPrefs.SetInt("TV5", 1);
        }
        else
        {
            PlayerPrefs.SetInt("TV5", 0);
        }

        if (CheckBoxes[5].isOn)
        {
            PlayerPrefs.SetInt("TV6", 1);
        }
        else
        {
            PlayerPrefs.SetInt("TV6", 0);
        }

        if (CheckBoxes[6].isOn)
        {
            PlayerPrefs.SetInt("TV7", 1);
        }
        else
        {
            PlayerPrefs.SetInt("TV7", 0);
        }

        if (CheckBoxes[7].isOn)
        {
            PlayerPrefs.SetInt("TV8", 1);
        }
        else
        {
            PlayerPrefs.SetInt("TV8", 0);
        }

        if (CheckBoxes[8].isOn)
        {
            PlayerPrefs.SetInt("TV9", 1);
        }
        else
        {
            PlayerPrefs.SetInt("TV9", 0);
        }

        if (CheckBoxes[9].isOn)
        {
            PlayerPrefs.SetInt("TV10", 1);
        }
        else
        {
            PlayerPrefs.SetInt("TV10", 0);
        }
    }

    void Start()
    {
        if (PlayerPrefs.GetInt("TV1") == 1)
        {
            CheckBoxes[0].isOn = true;
        }
        if (PlayerPrefs.GetInt("TV2") == 1)
        {
            CheckBoxes[1].isOn = true;
        }
        if (PlayerPrefs.GetInt("TV3") == 1)
        {
            CheckBoxes[2].isOn = true;
        }
        if (PlayerPrefs.GetInt("TV4") == 1)
        {
            CheckBoxes[3].isOn = true;
        }
        if (PlayerPrefs.GetInt("TV5") == 1)
        {
            CheckBoxes[4].isOn = true;
        }
        if (PlayerPrefs.GetInt("TV6") == 1)
        {
            CheckBoxes[5].isOn = true;
        }
        if (PlayerPrefs.GetInt("TV7") == 1)
        {
            CheckBoxes[6].isOn = true;
        }
        if (PlayerPrefs.GetInt("TV8") == 1)
        {
            CheckBoxes[7].isOn = true;
        }
        if (PlayerPrefs.GetInt("TV9") == 1)
        {
            CheckBoxes[8].isOn = true;
        }
        if (PlayerPrefs.GetInt("TV10") == 1)
        {
            CheckBoxes[9].isOn = true;
        }
    }
}
