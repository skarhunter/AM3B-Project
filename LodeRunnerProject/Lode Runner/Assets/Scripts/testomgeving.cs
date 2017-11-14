using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class testomgeving : MonoBehaviour {
	public Text timerLabel;
	public bool starter = false;
	public float startTimer = 1;

	private float time;

	void Update() {
		

		if (startTimer > 0) {
			
			if (starter) {
				time += Time.deltaTime;
			}

			var minutes = Mathf.FloorToInt(time / 60); 
			var seconds = time % 60;
			var fraction = (time * 100) % 100;

			//update the label value
			timerLabel.text = string.Format ("{0:00} : {1:00}", minutes, seconds);
		} 
	}

	public void stopTime(){
		startTimer = -1;
	}



}