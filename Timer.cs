using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public static int CountMinuteOnesDigit;
	public static int CountMinuteTensDigit;
    public static int CountSecondOnesDigit;
	public static int CountSecondTensDigit;
    public static float CountMilliSecond;
    public static string MilliFormat;


	public GameObject TextMillisecond;
	public GameObject TextSecondOnesDigit;
	public GameObject TextSecondTensDigit;
	public GameObject TextMinuteOnesDigit;
	public GameObject TextMinuteTensDigit;

    void Start()
    {
		CountSecondTensDigit = 0;
		CountMinuteTensDigit = 0;

    }


    void Update()
    {
        CountMilliSecond += Time.deltaTime * 10;
        MilliFormat = CountMilliSecond.ToString("F0");
        TextMillisecond.GetComponent<Text>().text = "" + MilliFormat;

        if (CountMilliSecond >= 10)
        {
            CountMilliSecond = 0;
            CountSecondOnesDigit += 1;
        }

        if (CountSecondOnesDigit >= 10)
        {
            CountSecondOnesDigit = 0;
            CountSecondTensDigit += 1;
        }

		if (CountSecondTensDigit >= 6)
        {
            CountSecondTensDigit = 0;
            CountMinuteOnesDigit += 1;
        }
	
	
	    if (CountMinuteOnesDigit >= 10)
        {
            CountMinuteOnesDigit = 0;
            CountMinuteTensDigit += 1;
        }

		if (CountMinuteTensDigit >= 6)
        {
            CountMinuteTensDigit = 0;
        }
	
	
	// This part allows you to display the numbers counted in the background.	
	TextSecondOnesDigit.GetComponent<Text>().text = "" + CountSecondOnesDigit;
	TextSecondTensDigit.GetComponent<Text>().text = "" + CountSecondTensDigit;	
	TextMinuteOnesDigit.GetComponent<Text>().text = "" + CountMinuteOnesDigit;
	TextMinuteTensDigit.GetComponent<Text>().text = "" + CountMinuteTensDigit;


    }
	
	
}