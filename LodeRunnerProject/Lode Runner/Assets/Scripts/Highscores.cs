using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscores : MonoBehaviour {

    public Text scoreText1;
    public Text scoreText2;
    public Text scoreText3;
    public Text timeText1;
    public Text timeText2;
    public Text timeText3;
    public Text timeLeft;
    public Text scoreText;
    public string LevelDiedOn;

    void Start () {
        //Sets the level that the player died on.
        LevelDiedOn = PlayerPrefs.GetString("LevelDiedOn");
        timeLeft.text = "Time left";
    }
	
	void Update () {
        //Gives the score to the Died screen so it can display the appropriate scores.
        if (LevelDiedOn == "1")
        {
            scoreText.text = PlayerPrefs.GetFloat("TotalScore").ToString();
            scoreText1.text = PlayerPrefs.GetString("Score1");
            if (PlayerPrefs.GetString("Difficulty") != "easy")
            {
                timeText1.text = PlayerPrefs.GetString("timeLeft1");
            }
            else
            {
                timeLeft.text = "";
                timeText1.text = "";
            }
        }
        if (LevelDiedOn == "2")
        {
            scoreText.text = PlayerPrefs.GetFloat("TotalScore").ToString();
            scoreText1.text = PlayerPrefs.GetString("Score1");
            scoreText2.text = PlayerPrefs.GetString("Score2");
            if (PlayerPrefs.GetString("Difficulty") != "easy")
            {
                timeText1.text = PlayerPrefs.GetString("timeLeft1");
                timeText2.text = PlayerPrefs.GetString("timeLeft2");
            } else {
                timeLeft.text = "";
                timeText1.text = "";
                timeText2.text = "";
            }
        }
        if (LevelDiedOn == "3")
        {
            scoreText.text = PlayerPrefs.GetFloat("TotalScore").ToString();
            scoreText1.text = PlayerPrefs.GetString("Score1");
            scoreText2.text = PlayerPrefs.GetString("Score2");
            scoreText3.text = PlayerPrefs.GetString("Score3");
            if (PlayerPrefs.GetString("Difficulty") != "easy")
            {
                timeText1.text = PlayerPrefs.GetString("timeLeft1");
                timeText2.text = PlayerPrefs.GetString("timeLeft2");
                timeText3.text = PlayerPrefs.GetString("timeLeft3");
            } else {
                timeLeft.text = "";
                timeText1.text = "";
                timeText2.text = "";
                timeText3.text = "";
            }
        }
    }
}
