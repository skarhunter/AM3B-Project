using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public GUISkin tekstskin;
    public float Score = 0;
    public string LevelDiedOn;
    public float timeLeft;
    public float scoreNeeded;
    public float TotalScore;
    public float testmode;
    public float Immortal;
    public float Speed;
    public GameObject ExitBlock;

    void Start()
    {
        // Sets the speed for the enemys. 
        Speed = 2.25f;
        PlayerPrefs.SetFloat("speed", Speed);
        PlayerPrefs.Save();

        // Sets the value of immortal back to 0.
        Immortal = 0;

        // Sets the value of testmode back to 0.
        testmode = 0;
        PlayerPrefs.SetFloat("Testmode", testmode);
        PlayerPrefs.Save();

        // Set the total score back to 0
        TotalScore = PlayerPrefs.GetFloat("TotalScore");

        // Set the time and needed score according to the difficulty and level.
        if (PlayerPrefs.GetString("Difficulty") == "easy")
        {
            timeLeft = 9999999999999999999;
            if (SceneManager.GetActiveScene().name == "1")
            {
                scoreNeeded = 1;
                // the 2 lines below might not be needed.
                PlayerPrefs.SetFloat("TotalScore", 0f);
                PlayerPrefs.Save();
            }

            if (SceneManager.GetActiveScene().name == "2")
            {
                scoreNeeded = 2;
            }

            if (SceneManager.GetActiveScene().name == "3")
            {
                scoreNeeded = 3;
            }
        }
        if (PlayerPrefs.GetString("Difficulty") == "medium")
        {
            timeLeft = 120;
            if (SceneManager.GetActiveScene().name == "1")
            {
                scoreNeeded = 2;
                PlayerPrefs.SetFloat("TotalScore", 0f);
                PlayerPrefs.Save();
            }

            if (SceneManager.GetActiveScene().name == "2")
            {
                scoreNeeded = 4;
            }

            if (SceneManager.GetActiveScene().name == "3")
            {
                scoreNeeded = 6;
            }
        }
        if (PlayerPrefs.GetString("Difficulty") == "hard")
        {
            timeLeft = 60;

            if (SceneManager.GetActiveScene().name == "1")
            {
                scoreNeeded = 3;
                PlayerPrefs.SetFloat("TotalScore", 0f);
                PlayerPrefs.Save();
            }

            if (SceneManager.GetActiveScene().name == "2")
            {
                scoreNeeded = 6;
            }

            if (SceneManager.GetActiveScene().name == "3")
            {
                scoreNeeded = 9;
            }
        }

        // Sets current level as the level the player died on. When the player dies the correct scores can be loaded according to the level.
        LevelDiedOn = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("LevelDiedOn", LevelDiedOn);
        PlayerPrefs.Save();
    }

    // The score counter and the timer.
    void OnGUI()
    {
        GUI.skin = tekstskin;
        GUI.Label(new Rect(10, 10, 300, 100), "Score: " + Score);
        // If the difficulty is turned to easy the timer will be turned off.
        if (PlayerPrefs.GetString("Difficulty") != "easy")
        {
            GUI.Label(new Rect(10, 30, 300, 100), "Time: " + timeLeft);
        }
    }

    void Update()
    {
        if (PlayerPrefs.GetString("Difficulty") != "easy")
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                PlayerPrefs.SetString("LevelDiedOn", LevelDiedOn);
                PlayerPrefs.SetString("Score" + SceneManager.GetActiveScene().name + "", Score.ToString());
                PlayerPrefs.Save();
                Application.LoadLevel("Killed");
            }
        }

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.T))
        {
            testmode = 1;
            Debug.Log("Testmode");
            PlayerPrefs.SetFloat("Testmode", testmode);
            PlayerPrefs.Save();
        }

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.O))
        {
            Immortal = 1;
            PlayerPrefs.SetFloat("Immortal", Immortal);
            PlayerPrefs.Save();
        }

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.KeypadPlus))
        {
            Speed += 0.05f;
            PlayerPrefs.SetFloat("speed", Speed);
            PlayerPrefs.Save();
        }

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.KeypadMinus) && Speed > 0)
        {
            Speed -= 0.05f;
            PlayerPrefs.SetFloat("speed", Speed);
            PlayerPrefs.Save();
        }

        if (Speed < 0)
        {
            Speed = 0;
            PlayerPrefs.SetFloat("speed", Speed);
            PlayerPrefs.Save();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // if immortal is turned off and the player touches an enemy the player will be send to the Killed screen with his scores.
        if(Immortal == 0)
        {
            if (other.gameObject.name == "Enemy")
            {
                PlayerPrefs.SetString("LevelDiedOn", LevelDiedOn);
                PlayerPrefs.SetString("Score" + SceneManager.GetActiveScene().name + "", Score.ToString());
                PlayerPrefs.Save();
                Application.LoadLevel("Killed");
            }
        }

        if (other.gameObject.name == "Collectable")
        {
            Score += 1;
        }

        if (Score >= scoreNeeded)
        {
            ExitBlock.SetActive(false);
        }

        if (other.gameObject.name == "LevelExit")
        {
            PlayerPrefs.SetString("Score" + SceneManager.GetActiveScene().name + "", Score.ToString());
            if (PlayerPrefs.GetString("Difficulty") != "easy")
            {
                PlayerPrefs.SetString("timeLeft" + SceneManager.GetActiveScene().name + "", timeLeft.ToString());
            }
            PlayerPrefs.SetFloat("TotalScore", Score + TotalScore);
            PlayerPrefs.Save();
            levelManager.NextLevel();
        }
    }

    public class levelManager
    {
        public string currentScene;

        public static void NextLevel()
        {
            if ( SceneManager.GetActiveScene().name == "1")
            {
                Application.LoadLevel("2");
            }

            if ( SceneManager.GetActiveScene().name == "2")
            {
                Application.LoadLevel("3");
            }

            if (SceneManager.GetActiveScene().name == "3")
            {
                Application.LoadLevel("Ingame_results");
            }
        }
    }
}