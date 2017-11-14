using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerkill : MonoBehaviour {
    public float triggerKill;

    void start()
    {
        triggerKill = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player" && PlayerPrefs.GetFloat("Immortal") != 1)
        {
            triggerKill = 1;
            PlayerPrefs.SetFloat("triggerKill", triggerKill);
            PlayerPrefs.Save();
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player" && PlayerPrefs.GetFloat("Immortal") != 1)
        {
            triggerKill = 1;
            PlayerPrefs.SetFloat("triggerKill", triggerKill);
            PlayerPrefs.Save();
        }
    }
}
