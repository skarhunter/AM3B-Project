using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
// Zet de collectable uit zodra de speler het aanraakt.
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}
