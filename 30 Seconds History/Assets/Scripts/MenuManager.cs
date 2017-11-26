using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
    public void playButtonPressed()
    {
        SceneManager.LoadScene(1); //Loads the name selector
    }

    public void aboutButtonPressed()
    {
        SceneManager.LoadScene(6); //Loads the about section
    }
}
