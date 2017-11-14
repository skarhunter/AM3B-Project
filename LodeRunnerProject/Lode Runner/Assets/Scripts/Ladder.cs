using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour {

    public float speed;
    public bool climbing;
    public GameObject Antibounch;

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update()
    {
        if (climbing == true)
        {
            // If the player is colliding with a ladder and he/she presses W the player will go up.
            if (Input.GetKey(KeyCode.W))
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
                Antibounch.active = false;
            }

            // If the player is colliding with a ladder and he/she presses W the player will go down.
            else if (Input.GetKey(KeyCode.S))
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
                Antibounch.active = false;
            }

            else
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            }
        }

        if (climbing == false && Input.GetKeyUp(KeyCode.W) || climbing == false && Input.GetKeyUp(KeyCode.S) || climbing == false && Input.GetKeyUp(KeyCode.A) || climbing == false && Input.GetKeyUp(KeyCode.D))
        {
            Antibounch.active = true;
        }
    }

    // Turns climbing to true if the player is colliding with one of the ladder colliders.
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "MiniK_Tileset_For_Tiled_120" || other.gameObject.name == "MiniK_Tileset_For_Tiled_121" || other.gameObject.name == "MiniK_Tileset_For_Tiled_122" || other.gameObject.name == "MiniK_Tileset_For_Tiled_123")
        {
            climbing = true; 
        }
    }

    // Turns climbing to false if the player is no longer colliding with one of the ladder colliders.
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "MiniK_Tileset_For_Tiled_120" || other.gameObject.name == "MiniK_Tileset_For_Tiled_121" || other.gameObject.name == "MiniK_Tileset_For_Tiled_122" || other.gameObject.name == "MiniK_Tileset_For_Tiled_123")
        {
            climbing = false;
        }
    }
}