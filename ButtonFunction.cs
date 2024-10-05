using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{
   
   public GameObject PausePanel;
   public GameObject PauseButton;
   
   
       void Start()
    {
        PausePanel.SetActive (false);

    }
   
   
   
   // Once click on the button, it will load a scene that the index number was set to 0.
   public void LoadMainMenu ()
    {
        SceneManager.LoadScene(0); 
		Time.timeScale = 1;

    }


    public void SelectTrack1()
    {
        SceneManager.LoadScene(1);
		Time.timeScale = 1;
    }
	
    public void SelectTrack2()
    {
        SceneManager.LoadScene(2);
		Time.timeScale = 1;
    }

    public void SelectTrack3()
    {
        SceneManager.LoadScene(3);
		Time.timeScale = 1;
    }


    // Once click on the "Quit" button, it will quit the game application.
    //Please note that it will only work once you published the game to an APP. 

    public void QuitGame()
    {
        Application.Quit ();

    }


//In the game, we want to be able to pause game and resume game.

    public void Pause()
    {
        PausePanel.SetActive (true);
		PauseButton.SetActive (false);
		Time.timeScale = 0;
    }


    public void Continue()
    {
        PausePanel.SetActive (false);
		PauseButton.SetActive (true);
		Time.timeScale = 1;
    }




}