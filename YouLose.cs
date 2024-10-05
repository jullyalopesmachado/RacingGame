using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class YouLose : MonoBehaviour {

	public GameObject YouLoseText;
	public AudioSource YouLoseAudio;
	public GameObject CarCameraGroup;
	public GameObject YouLoseCamera;
	public GameObject Car;
	public GameObject AICar1;
	public GameObject MenuPage;
	public GameObject LapTimer;
	public GameObject PauseButton;
	public GameObject FinishLineTrigger;
	

	void Start () {
		YouLoseText.SetActive (false);
		YouLoseCamera.SetActive (false);
		MenuPage.SetActive (false);
	}

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "AIcar1")
        {
		PauseButton.SetActive (false);
		Car.GetComponent<CarController>().enabled = false;
		FinishLineTrigger.GetComponent<BoxCollider>().enabled = false;
		Car.GetComponent<CarUserControl>().enabled = false;
		AICar1.GetComponent<CarController>().enabled = false;
		AICar1.GetComponent<CarAIControl>().enabled = false;
		CarCameraGroup.SetActive (false);
		YouLoseAudio.Play ();
		YouLoseText.SetActive (true);
		YouLoseCamera.SetActive (true);
		LapTimer.SetActive (false);
		StartCoroutine (YouLoseSequence ());		
        }
    }



	IEnumerator YouLoseSequence () {
		yield return new WaitForSeconds (2f);
		MenuPage.SetActive (true);


	}


}




