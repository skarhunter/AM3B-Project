using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour {

    // Loads levels and sets things for the appropriat difficulty.
    public void easy()
    {
        PlayerPrefs.SetString("Difficulty", "easy");
        PlayerPrefs.SetFloat("TotalScore", 0f);
        PlayerPrefs.Save();
        Application.LoadLevel("3");
    }

    public void medium()
    {
        PlayerPrefs.SetString("Difficulty", "medium");
        PlayerPrefs.SetFloat("TotalScore", 0f);
        PlayerPrefs.Save();
        Application.LoadLevel("3");
    }

    public void hard()
    {
        PlayerPrefs.SetString("Difficulty", "hard");
        PlayerPrefs.SetFloat("TotalScore", 0f);
        PlayerPrefs.Save();
        Application.LoadLevel("3");
    }

    public void loadlevel1 () {
        PlayerPrefs.SetFloat("TotalScore", 0f);
        PlayerPrefs.Save();
        Application.LoadLevel ("1");
	}

    public void loadlevel2()
    {
        Application.LoadLevel("2");
    }

    public void loadlevel3()
    {
        Application.LoadLevel("3");
    }

    public void loaddifficultyselect()
    {
        Application.LoadLevel("DifficultySelect");
    }

    public void loadlevelretry()
    {
        Application.LoadLevel(PlayerPrefs.GetString("LevelDiedOn"));
    }

    public void loadlevelScore()
    {
        Application.LoadLevel("Ingame_results");
    }

    public void loadCredits () {
		Application.LoadLevel ("Credits");
	}

    public void loadKilled()
    {
        Application.LoadLevel("Killed");
    }

    public void loadLadderInformation () {
		Application.LoadLevel ("LadderInformation");
	}

	public void back () {
		Application.LoadLevel ("Home");
	}

    public void exit () {
		Application.Quit();
	}
}