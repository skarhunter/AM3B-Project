using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{

    public GameObject target;
    public float speed;
    public float Turn;
    public float TurnTime;
    public float positionXright;
    public float positionXleft;



    void Start()
    {
        //this.transform.Rotate(new Vector3(0, 0, 0), Space.World);
    }

    void Update()
    {
        /*
        transform.LookAt(target.transform.position);

        if (Vector2.Distance(transform.position, target.transform.position) > 0.15f) {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed* Time.deltaTime);
        }*/

        //this.transform.Translate(new Vector2(this.transform.position.x, 0));
        //rotate to look at the player
        //transform.LookAt(target.transform.position);
        //transform.Rotate(new Vector2(0, 180), Space.Self);//correcting the original rotation

        //transform.eulerAngles = new Vector2(0, 0,);

        /*
        Vector2 targetPostition = new Vector2(target.transform.position.x, target.transform.position.y);
        this.transform.LookAt(targetPostition);

        if (this.transform.position.x <= target.transform.position.x)
        {
            this.transform.Rotate(new Vector2(0,-180), Space.World);
        }

        //move towards the player
        if (Vector2.Distance(this.transform.position, target.transform.position) > 0.15f)
        {
            transform.Translate(new Vector2(speed * Time.deltaTime, 0));
        }*/

        /*
        Debug.Log(Time.time + " | " + TurnTime + " | " + Turn);

        transform.position = new Vector3(Mathf.PingPong(Time.time, TurnTime), transform.position.y, transform.position.z);
        if (Mathf.PingPong(Time.time, TurnTime) > Turn)
        {
            this.transform.Rotate(new Vector3(0, 180, 0), Space.World);
        }
        else
        {
            this.transform.Rotate(new Vector3(0, 0, 0), Space.World);
        }
        */

        /*
        transform.Translate(new Vector2(speed * Time.deltaTime, 0));

        if (transform.position.x < positionXa)
        {
            transform.Rotate(new Vector3(0, -180, 0), Space.World);
        }

        if (transform.position.x > positionXb)
        {
            transform.Rotate(new Vector3(0, 0, 0), Space.World);
        }*/

        /*
        if (positionXa - transform.position.x > 4.0f)
        {
            useSpeed = speed;
        }
        else if (positionXa - transform.position.x > -4.0f)
        {
            useSpeed = -speed;
        }

        Debug.Log(positionXa - transform.position.x < 4.0f);

        transform.Translate(useSpeed * Time.deltaTime, 0, 0);
        */

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