using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rememberer : MonoBehaviour {

    public Text score1;
    public Text score2;
    public Text score3;
    public Text score1Long;
    public Text score2Long;
    public Text score3Long;
    public Text scoreTotal;
    public Text memoryShort;
    public Text memoryLong;
    public string thoughts1;
    public string thoughts2;
    public string thoughts3;
    public string thoughts4;
    public Text highscore1;
    public Text highscore2;
    public Text highscore3;
    public Text highscore;

    // Use this for initialization
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "1")
        {
            //score1 = GameObject.FindGameObjectWithTag("Score");
        }
        if (SceneManager.GetActiveScene().name == "2")
        {

        }
        if (SceneManager.GetActiveScene().name == "3")
        {

        }
    }

    void Awake () {
        DontDestroyOnLoad(this.gameObject);   
    }
	
	// Update is called once per frame
	void Update () {
        score1Long = score1;
        score2Long = score2;
        score3Long = score3;
        //scoreTotal = (score1 + score2 + score3);
        thoughts1 = score1.text;
        thoughts2 = score2.text;
        thoughts3 = score3.text;
        thoughts4 = scoreTotal.text;
        highscore1.text = thoughts1;
        highscore2.text = thoughts2;
        highscore3.text = thoughts3;
        highscore.text = thoughts4;
        //GameObject.FindGameObjectWithTag("Highscore");
    }
}
