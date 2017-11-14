using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
    public bool Horizontal;
    public bool Vertical;
    public float speed;
    public float positionXright;
    public float positionXleft;
    public float positionYup;
    public float positionYdown;

    void Update()
    {
        // Turns off the enemys if testmode is turned on.
        if (PlayerPrefs.GetFloat("Testmode") == 1)
        {
            gameObject.SetActive(false);
        }
        // Sets the speed of the enemy according to the difficulty.
        if (PlayerPrefs.GetString("Difficulty") == "easy")
        {
            speed = 1.125f;
        }
        if (PlayerPrefs.GetString("Difficulty") == "medium")
        {
            speed = 2f;
        }
        if (PlayerPrefs.GetString("Difficulty") == "hard")
        {
            speed = 4f;
        }

        // Makes the movement vertical if the box is checked in the unity editor
        if (Vertical)
        {
            if (transform.position.y >= positionYup)
            {
                transform.Rotate(new Vector3(180, 0, 0), Space.World);
            }
            if (transform.position.y <= positionYdown)
            {
                transform.Rotate(new Vector3(-180, 0, 0), Space.World);
            }
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        // Turns the enemy opside down.
        else if (Horizontal)
        {
            if (transform.position.x >= positionXright)
            {
                transform.Rotate(new Vector3(0, -180, 0), Space.World);
            }
            if (transform.position.x <= positionXleft)
            {
                transform.Rotate(new Vector3(0, 180, 0), Space.World);
            }
            transform.Translate(speed * Time.deltaTime, 0, 0);
        } else {
            if (transform.position.x >= positionXright)
            {
                transform.Rotate(new Vector3(0, 180, 0), Space.World);
            }
            if (transform.position.x <= positionXleft)
            {
                transform.Rotate(new Vector3(0, -180, 0), Space.World);
            }
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }

    //Kills the enemy when the player touches the enemy and when the immortality
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player" && PlayerPrefs.GetFloat("Immortal") == 1)
        {
            gameObject.SetActive(false);
        }
    }
}