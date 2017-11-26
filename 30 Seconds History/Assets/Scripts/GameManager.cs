using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int timeLimit = 33;

    public float timePassed;

    public float timeLeft;

    public float linearInterp = 0;

    public GameObject getRectTrans;

    public Rect rectTrans;

    public Image img;

    public Text timeText;

    public Text[] textFields;

    public Toggle[] checkBoxes;

    public Toggle[] checkBoxesEras;

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

    // Use this for initialization
    void Start () {
        if (unused == null || unused.Count == 0)
        {
            unused = terms1.ToList<Term>();
            if (checkBoxesEras[0].isOn)
            {
                foreach (Term term in terms1)
                {
                    unused.Add(term);
                }
            }
            if (checkBoxesEras[1].isOn)
            {
                foreach (Term term in terms2)
                {
                    unused.Add(term);
                }
            }
            if (checkBoxesEras[2].isOn)
            {
                foreach (Term term in terms3)
                {
                    unused.Add(term);
                }
            }
            if (checkBoxesEras[3].isOn)
            {
                foreach (Term term in terms4)
                {
                    unused.Add(term);
                }
            }
            if (checkBoxesEras[4].isOn)
            {
                foreach (Term term in terms5)
                {
                    unused.Add(term);
                }
            }
            if (checkBoxesEras[5].isOn)
            {
                foreach (Term term in terms6)
                {
                    unused.Add(term);
                }
            }
            if (checkBoxesEras[6].isOn)
            {
                foreach (Term term in terms7)
                {
                    unused.Add(term);
                }
            }
            if (checkBoxesEras[7].isOn)
            {
                foreach (Term term in terms8)
                {
                    unused.Add(term);
                }
            }
            if (checkBoxesEras[8].isOn)
            {
                foreach (Term term in terms9)
                {
                    unused.Add(term);
                }
            }
            if (checkBoxesEras[9].isOn)
            {
                foreach (Term term in terms10)
                {
                    unused.Add(term);
                }
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
            timeLeft = timeLimit;
            timePassed = 0;
            getRandomTerms();
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

}
