using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public int timeLimit = 30;

    public float timePassed;

    public float timeLeft;

    public float linearInterp = 0;

    public GameObject getRectTrans;

    public Rect rectTrans;

    public Image img;

    public Text timeText;

    public Text[] textFields;

    public Toggle[] checkBoxes;

    public bool[] checkBoxesChecked = new bool[5];

    public Color beginColor;

    private Random rngesus = new Random();

    private bool termsChosen = false;

    public Term[] terms1;
    public Term[] terms2;
    public Term[] terms3;
    public Term[] terms4;
    public Term[] terms5;
    public Term[] terms6;
    public Term[] terms7;
    public Term[] terms8;
    public Term[] terms9;
    public Term[] terms10;

    private static List<Term> unused = new List<Term>();

    private Term[] currentTerms = new Term[5];

    public Animator anim;

    public PlayerSelectorManager psm;

    // Use this for initialization
    void Start () {
        timeLeft = timeLimit;
        timePassed = 0;
        if (unused == null || unused.Count == 0)
        {
            unused = terms1.ToList<Term>();
            if (PlayerPrefs.GetInt("TV1") == 1)
            {
                
                foreach (Term term in terms1)
                {
                    unused.Add(term);
                }
                Debug.Log("Loaded in Era 1");
            }
            if (PlayerPrefs.GetInt("TV2") == 1)
            {
                foreach (Term term in terms2)
                {
                    unused.Add(term);
                }
                Debug.Log("Loaded in Era 2");
            }
            if (PlayerPrefs.GetInt("TV3") == 1)
            {
                foreach (Term term in terms3)
                {
                    unused.Add(term);
                }
                Debug.Log("Loaded in Era 3");
            }
            if (PlayerPrefs.GetInt("TV4") == 1)
            {
                foreach (Term term in terms4)
                {
                    unused.Add(term);
                }
                Debug.Log("Loaded in Era 4");
            }
            if (PlayerPrefs.GetInt("TV5") == 1)
            {
                foreach (Term term in terms5)
                {
                    unused.Add(term);
                }
                Debug.Log("Loaded in Era 5");
            }
            if (PlayerPrefs.GetInt("TV6") == 1)
            {
                foreach (Term term in terms6)
                {
                    unused.Add(term);
                }
                Debug.Log("Loaded in Era 6");
            }
            if (PlayerPrefs.GetInt("TV7") == 1)
            {
                foreach (Term term in terms7)
                {
                    unused.Add(term);
                }
                Debug.Log("Loaded in Era 7");
            }
            if (PlayerPrefs.GetInt("TV8") == 1)
            {
                foreach (Term term in terms8)
                {
                    unused.Add(term);
                }
                Debug.Log("Loaded in Era 8");
            }
            if (PlayerPrefs.GetInt("TV9") == 1)
            {
                foreach (Term term in terms9)
                {
                    unused.Add(term);
                }
                Debug.Log("Loaded in Era 9");
            }
            if (PlayerPrefs.GetInt("TV10") == 1)
            {
                foreach (Term term in terms10)
                {
                    unused.Add(term);
                }
                Debug.Log("Loaded in Era 10");
            }
        }
    }
	
    void Update()
    {
        timePassed += Time.deltaTime;
        timeLeft -= Time.deltaTime;
    }

	// Update is called once per frame
	void FixedUpdate () {
        if (!termsChosen && timeLeft < 30)
        {
            getRandomTerms();
            termsChosen = true;
        }
        else if (timeLeft < 0)
        {
            //checkForUnchecked();
            onTimeRunOut();
        }
        linearInterp = timePassed / timeLimit;
        //rectTrans.xMin += widthConstant;
        img.color = Color.Lerp(beginColor, Color.red, linearInterp);
        timeText.text = timeLeft.ToString("0");
        checkCheckBoxes();
	}

    public void onStartButtonPressed()
    {
        onGameButtonPressed();
    }

    public void onGameButtonPressed()
    {
        timePassed = 0;
        timeLeft = timeLimit;
        getRandomTerms();
    }

    public void checkCheckBoxes()
    {
        if (checkBoxes[0].isOn)
        {
            checkBoxesChecked[0] = true;
        }
        else
        {
            checkBoxesChecked[0] = false;
        }

        if (checkBoxes[1].isOn)
        {
            checkBoxesChecked[1] = true;
        }
        else
        {
            checkBoxesChecked[1] = false;
        }

        if (checkBoxes[2].isOn)
        {
            checkBoxesChecked[2] = true;
        }
        else
        {
            checkBoxesChecked[2] = false;
        }

        if (checkBoxes[3].isOn)
        {
            checkBoxesChecked[3] = true;
        }
        else
        {
            checkBoxesChecked[3] = false;
        }

        if (checkBoxes[4].isOn)
        {
            checkBoxesChecked[4] = true;
        }
        else
        {
            checkBoxesChecked[4] = false;
        }
    }

    void getRandomTerms()
    {
        for (int i = 0; i < currentTerms.Length; i++)
        {
            int randomInt = Random.Range(0, unused.Count);
            textFields[i].text = unused[randomInt].term.ToString(); //Sets a new question from the list of unused questions
            unused.RemoveAt(randomInt);
        }
        
    }

    void onTimeRunOut()
    {
        SceneManager.LoadScene(5);
    }

    //void checkForUnchecked()
    //{
    //    for (int i = 0; i < currentTerms.Length; i++)
    //    {
    //        if (checkBoxesChecked[i] == false)
    //        {
    //            unused.Add(currentTerms[i]);
    //            Debug.Log("Adding " + currentTerms[i].term + " Back to the mix.");
    //        }
    //    }
        
        
    //}

}
