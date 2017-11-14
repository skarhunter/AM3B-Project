using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]

public class tiimer : MonoBehaviour {

	public Text timerText;
	private float startTime;
	private float countdownTime;
	private bool finisheded= false;
	public int passed = 1;


	public Camera cam2;
	public Camera cam1;
	public GameObject car;

	public AudioClip checkpointNoise;
	public AudioClip finish;
	public AudioSource audio;

	private Rigidbody rb;

	public Text timer;
	public float startTimer = 1;
	private float time;
	public bool jemoder = false;

	testomgeving ongui;


	public float raceTime = 0.0f;

	private GameObject checkPoint1;
    private GameObject checkPoint2;
    private GameObject checkPoint3;
	private GameObject checkPoint4;
	private GameObject checkPoint5;
	private GameObject checkPoint6;
	private GameObject checkPoint7;
	private GameObject checkPoint8;
	private GameObject checkPoint9;
	private GameObject checkPoint10;
	private GameObject checkPoint11;
	private GameObject checkPoint12;
	private GameObject checkPoint13;
	private GameObject checkPoint14;
	private GameObject checkPoint15;
	private GameObject checkPoint16;
	private GameObject checkPoint17;
	private GameObject checkPoint18;
	private GameObject checkPoint19;
	private GameObject checkPoint20;
    private GameObject checkPoint21;

    // Use this for initialization
    void Start () {
		ongui = GameObject.FindObjectOfType<testomgeving> ();
		StartCoroutine (animation());
		rb = GetComponent<Rigidbody> ();
		rb.isKinematic = true;
		timerText.enabled = false;

		checkPoint1 = GameObject.Find ("Checkpoint1");
		checkPoint2 = GameObject.Find ("Checkpoint2");
        checkPoint3 = GameObject.Find ("Checkpoint3");
		checkPoint4 = GameObject.Find ("Checkpoint4");
		checkPoint5 = GameObject.Find ("Checkpoint5");
		checkPoint6 = GameObject.Find ("Checkpoint6");
		checkPoint7 = GameObject.Find ("Checkpoint7");
		checkPoint8 = GameObject.Find ("Checkpoint8");
		checkPoint9 = GameObject.Find ("Checkpoint9");
		checkPoint10 = GameObject.Find ("Checkpoint10");
		checkPoint11 = GameObject.Find ("Checkpoint11");
		checkPoint12 = GameObject.Find ("Checkpoint12");
		checkPoint13 = GameObject.Find ("Checkpoint13");
		checkPoint14 = GameObject.Find ("Checkpoint14");
		checkPoint15 = GameObject.Find ("Checkpoint15");
		checkPoint16 = GameObject.Find ("Checkpoint16");
		checkPoint17 = GameObject.Find ("Checkpoint17");
		checkPoint18 = GameObject.Find ("Checkpoint18");
		checkPoint19 = GameObject.Find ("Checkpoint19");
		checkPoint20 = GameObject.Find ("Checkpoint20");
        checkPoint21 = GameObject.Find("Checkpoint21");

        audio = GetComponent<AudioSource>();
    }

	void Update () {

	}
		

	IEnumerator finished (){
		yield return new WaitForSeconds (3);
		Application.LoadLevel ("Ingame_results");
	}

	IEnumerator animation () {
		yield return new WaitForSeconds (14);
		ongui.starter = true;
		cam2.enabled = false;
		cam1.enabled = true;
		timerText.enabled = true;
		rb.isKinematic = false;
	}


    void OnTriggerEnter(Collider checkpoint )
    {
		if (checkpoint.gameObject.name == "Checkpoint1") {
			if (passed == 1) {
				Component[] renderers3 = checkPoint1.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
					//finisheded = true;
				}

				Component[] renderers4 = checkPoint2.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 2;

              
            }

		}


		if (checkpoint.gameObject.name == "Checkpoint2") {

			if (passed == 2) {
				Component[] renderers3 = checkPoint2.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint3.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 3;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint3") {

			if (passed == 3) {
				Component[] renderers3 = checkPoint3.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint4.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 4;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint4") {

			if (passed == 4) {
				Component[] renderers3 = checkPoint4.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint5.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 5;
			}		
		}

		if (checkpoint.gameObject.name == "Checkpoint5") {

			if (passed == 5) {
				Component[] renderers3 = checkPoint5.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint6.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 6;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint6") {

			if (passed == 6) {
				Component[] renderers3 = checkPoint6.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint7.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 7;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint7") {
			
			if (passed == 7) {
				Component[] renderers3 = checkPoint7.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint8.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 8;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint8") {

			if (passed == 8) {
				Component[] renderers3 = checkPoint8.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint9.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 9;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint9") {

			if (passed == 9) {
				Component[] renderers3 = checkPoint9.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint10.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 10;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint10") {

			if (passed == 10) {
				Component[] renderers3 = checkPoint10.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint11.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 11;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint11") {

			if (passed == 11) {
				Component[] renderers3 = checkPoint11.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint12.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 12;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint12") {

			if (passed == 12) {
				Component[] renderers3 = checkPoint12.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint13.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 13;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint13") {

			if (passed == 13) {
				Component[] renderers3 = checkPoint13.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint14.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 14;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint14") {

			if (passed == 14) {
				Component[] renderers3 = checkPoint14.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint15.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 15;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint15") {

			if (passed == 15) {
				Component[] renderers3 = checkPoint15.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint16.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 16;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint16") {

			if (passed == 16) {
				Component[] renderers3 = checkPoint16.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint17.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 17;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint17") {

			if (passed == 17) {
				Component[] renderers3 = checkPoint17.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint18.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 18;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint18") {

			if (passed == 18) {
				Component[] renderers3 = checkPoint18.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint19.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 19;
			}
		}

		if (checkpoint.gameObject.name == "Checkpoint19") {

			if (passed == 19) {
				Component[] renderers3 = checkPoint19.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				Component[] renderers4 = checkPoint20.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}
				audio.PlayOneShot (checkpointNoise, 0.7f);
				passed = 20;
			}
		}

        if (checkpoint.gameObject.name == "Checkpoint20")
        {

            if (passed == 20)
            {
                Component[] renderers3 = checkPoint20.GetComponentsInChildren(typeof(Renderer));
                foreach (Renderer childRenderer in renderers3)
                {
                    childRenderer.material.color = Color.red;
                    childRenderer.material.SetColor("_EmissionColor", Color.red);
                }

                Component[] renderers4 = checkPoint21.GetComponentsInChildren(typeof(Renderer));
                foreach (Renderer childRenderer in renderers4)
                {
                    childRenderer.material.color = Color.green;
                    childRenderer.material.SetColor("_EmissionColor", Color.green);
                }
                audio.PlayOneShot(checkpointNoise, 0.7f);
                passed = 21;
            }
        }

        if (checkpoint.gameObject.name == "Checkpoint21") {

			if (passed == 21) {
				ongui.stopTime ();
				Component[] renderers3 = checkPoint21.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers3) {
					childRenderer.material.color = Color.red;
					childRenderer.material.SetColor ("_EmissionColor", Color.red);
				}

				/*Component[] renderers4 = checkPoint20.GetComponentsInChildren (typeof(Renderer));
				foreach (Renderer childRenderer in renderers4) {
					childRenderer.material.color = Color.green;
					childRenderer.material.SetColor ("_EmissionColor", Color.green);
				}*/
				audio.PlayOneShot (finish, 0.7f);
				passed = 22;
				timerText.color = Color.yellow;
				StartCoroutine (finished ());
			
			}
		}
    }
}
