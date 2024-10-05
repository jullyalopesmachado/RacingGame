using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CarCountDown : MonoBehaviour {

	public GameObject CountDownText;
	public AudioSource CountDownAudio;
	public AudioSource GoAudio;
	public GameObject LapTimer;
	public GameObject Car;
	public GameObject AICar1;
	public AudioSource BGMusic;

	void Start () {
		LapTimer.SetActive (false);
		Car.GetComponent<CarController>().enabled = false;
		Car.GetComponent<CarUserControl>().enabled = false;
		AICar1.GetComponent<CarController>().enabled = false;
		AICar1.GetComponent<CarAIControl>().enabled = false;
		StartCoroutine (CountStart ());		
	}





	IEnumerator CountStart () {
		yield return new WaitForSeconds (0.5f);

		CountDownText.GetComponent<Text> ().text = "3";
		CountDownAudio.Play ();
		CountDownText.SetActive (true);

		yield return new WaitForSeconds (1);

		CountDownText.SetActive (false);
		CountDownText.GetComponent<Text> ().text = "2";
		CountDownAudio.Play ();
		CountDownText.SetActive (true);

		yield return new WaitForSeconds (1);

		CountDownText.SetActive (false);
		CountDownText.GetComponent<Text> ().text = "1";
		CountDownAudio.Play ();
		CountDownText.SetActive (true);

		yield return new WaitForSeconds (1);

		CountDownText.SetActive (false);
		GoAudio.Play ();
		BGMusic.Play ();
		LapTimer.SetActive (true);
		Car.GetComponent<CarController>().enabled = true;
		Car.GetComponent<CarUserControl>().enabled = true;
		AICar1.GetComponent<CarController>().enabled = true;
		AICar1.GetComponent<CarAIControl>().enabled = true;

	}


}



