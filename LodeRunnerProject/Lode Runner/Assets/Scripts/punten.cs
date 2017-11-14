using UnityEngine;
using System.Collections;

public class punten : MonoBehaviour
{
    public int score = 0;
    public GUISkin tekstskin;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void scoreUp()
    {
        score++;
    }

    void OnGUI()
    {
        GUI.skin = tekstskin;
        int punten = (score / 2);
        GUI.Label(new Rect(10, 10, 300, 100), "Score: " + punten);

        if (punten >= 30)
        {
            GUI.Label(new Rect(0, 100, 300, 100), "Je hebt gewonnen");
        }
    }

   
}