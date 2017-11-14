using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    public float PauseMenu;
    public Canvas Menu;

    public void Start () {
        Menu.enabled = false;
        Time.timeScale = 1;
    }
	
	public void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            Menu.enabled = true;
        }
    }

    public void Resume()
    {
        Menu.enabled = false;
        Time.timeScale = 1;
    }

    public void mainMenu()
    {
        Application.LoadLevel("Home");
        Time.timeScale = 1;
    }

    public IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(1);
    }
}