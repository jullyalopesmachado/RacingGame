﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FinishLineFireworksV2 : MonoBehaviour {

	public GameObject CheerPaper1;
	public GameObject CheerPaper2;
	public GameObject CheerPaper3;
	public GameObject CheerPaper4;
	public GameObject Fireworks;	
	
	public AudioSource CheerAudio1;
	public AudioSource CheerAudio2;



	void Start () {

				CheerPaper1.SetActive (false);
				CheerPaper2.SetActive (false);
				CheerPaper3.SetActive (false);
				CheerPaper4.SetActive (false);
				Fireworks.SetActive (false);
				CheerPaper1.GetComponent<MeshRenderer>().enabled = false;
				CheerPaper2.GetComponent<MeshRenderer>().enabled = false;
				CheerPaper3.GetComponent<MeshRenderer>().enabled = false;
				CheerPaper4.GetComponent<MeshRenderer>().enabled = false;
				Fireworks.GetComponent<MeshRenderer>().enabled = false;
		
	}

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {

		StartCoroutine (PlayFireworks ());		
        }
    }
	
	



	IEnumerator PlayFireworks () {
		yield return new WaitForSeconds (0.05f);

		CheerPaper1.SetActive (true);
		CheerAudio1.Play ();

		yield return new WaitForSeconds (0.4f);
		CheerPaper1.GetComponent<MeshRenderer>().enabled = true;
		CheerPaper2.SetActive (true);
		CheerAudio2.Play ();
		Fireworks.SetActive (true);

		yield return new WaitForSeconds (0.4f);
		CheerPaper2.GetComponent<MeshRenderer>().enabled = true;
		Fireworks.GetComponent<MeshRenderer>().enabled = true;
		CheerPaper3.SetActive (true);
	
		
		yield return new WaitForSeconds (0.4f);
		CheerPaper3.GetComponent<MeshRenderer>().enabled = true;
		CheerPaper4.SetActive (true);
		
		yield return new WaitForSeconds (0.4f);
		CheerPaper4.GetComponent<MeshRenderer>().enabled = true;
		

	}


}



