using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSwitchCamerasWith4Key : MonoBehaviour {

    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;

    void Start () {

        camera1.SetActive(true);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
    }
	

	void Update () {
		
        if (Input.GetKeyDown ("1"))
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(false);
        }

        if (Input.GetKeyDown ("2"))
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
            camera3.SetActive(false);
            camera4.SetActive(false);
        }


        if (Input.GetKeyDown ("3"))
        {
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(true);
            camera4.SetActive(false);
        }

        if (Input.GetKeyDown ("4"))
        {
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(true);
        }






    }
}
