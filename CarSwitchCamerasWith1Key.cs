using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSwitchCamerasWith1Key : MonoBehaviour {

    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
	public int Counting;

    void Start () {

        camera1.SetActive(true);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
    }
	

	void Update () {
		if (Input.GetKeyDown ("c")){
			if (Counting == 3)
				{ Counting = 0; }		
			else 
				{ Counting += 1; }
			StartCoroutine (CameraSwitch());	
		}
	}
	
	IEnumerator CameraSwitch () {
		yield return new WaitForSeconds (0.001f);
		
		if(Counting == 0)
			{	camera1.SetActive(true);
			 	camera2.SetActive(false);
			 	camera3.SetActive(false);
			 	camera4.SetActive(false);
			}
				if(Counting == 1)
			{	camera1.SetActive(false);
			 	camera2.SetActive(true);
			 	camera3.SetActive(false);
			 	camera4.SetActive(false);
			}
				if(Counting == 2)
			{	camera1.SetActive(false);
			 	camera2.SetActive(false);
			 	camera3.SetActive(true);
			 	camera4.SetActive(false);
			}
				if(Counting == 3)
			{	camera1.SetActive(false);
			 	camera2.SetActive(false);
			 	camera3.SetActive(false);
			 	camera4.SetActive(true);
			}
		

			
		
	}
	
}
	
