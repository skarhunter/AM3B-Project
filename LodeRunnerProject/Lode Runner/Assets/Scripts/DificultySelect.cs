using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DificultySelect : MonoBehaviour {

	public void easy () {
        PlayerPrefs.SetString("Difficulty", "easy");
    }

    public void medium()
    {
        PlayerPrefs.SetString("Difficulty", "medium");
    }

    public void hard()
    {
        PlayerPrefs.SetString("Difficulty", "hard");
    }
}
