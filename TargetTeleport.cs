using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetTeleport : MonoBehaviour
{

	public GameObject ThisMarker;
	public GameObject NextMarker;
    public Transform NextMarkerPos;
	public GameObject Target;


	    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "AIcar1")
        {


        ThisMarker.SetActive(false);
		NextMarker.SetActive(true);
Target.transform.position = NextMarkerPos.transform.position;
        }
    }
	
	
}



