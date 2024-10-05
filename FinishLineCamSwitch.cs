using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class FinishLineCamSwitch : MonoBehaviour {

	public GameObject FinishText;
	public AudioSource FinishAudio;
	public GameObject CarCameraGroup;
	public GameObject FinishLineCamera;
	public GameObject Car;
	public GameObject AICar1;
	public GameObject MenuPage;
	public GameObject LapTimer;
	public GameObject PauseButton;
	public GameObject FinishLineTrigger;
	

	void Start () {
		FinishText.SetActive (false);
		FinishLineCamera.SetActive (false);
		MenuPage.SetActive (false);
	}

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
		FinishLineTrigger.GetComponent<BoxCollider>().enabled = false;
		Car.GetComponent<CarController>().enabled = false;
		Car.GetComponent<CarUserControl>().enabled = false;
		AICar1.GetComponent<CarController>().enabled = false;
		AICar1.GetComponent<CarAIControl>().enabled = false;
		CarCameraGroup.SetActive (false);
		FinishAudio.Play ();
		FinishText.SetActive (true);
		FinishLineCamera.SetActive (true);
		LapTimer.SetActive (false);
		PauseButton.SetActive (false);
		StartCoroutine (FinishLineSequence ());		
        }
    }



	IEnumerator FinishLineSequence () {
		yield return new WaitForSeconds (2f);
		MenuPage.SetActive (true);


	}


}




