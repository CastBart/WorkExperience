using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClicks : MonoBehaviour {
    public static bool show = false;
    public Button easyButton;
    public Button medButton;
    public Button hardButton;
    public Canvas canvas;
    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(show)
        {
            easyButton.interactable = true;
            medButton.interactable = true;
            hardButton.interactable = true;
            easyButton.enabled = true;
            medButton.enabled = true;
            hardButton.enabled = true;
            canvas.enabled = true;
        }
        else
        {
            easyButton.interactable = false;
            medButton.interactable = false;
            hardButton.interactable = false;
            easyButton.enabled = false;
            medButton.enabled = false;
            hardButton.enabled = false;
            canvas.enabled = false;
        }
        
	}

    public void EasyClick()
    {
        SceneManager.LoadScene("MazeScene", LoadSceneMode.Single);
    }

    public void MedClick()
    {
        SceneManager.LoadScene("MazeSceneMed", LoadSceneMode.Single);
    }

    public void HardClick()
    {
        SceneManager.LoadScene("MazeSceneHard", LoadSceneMode.Single);
    }

    public void exitClick()
    {
        Application.Quit();
    }
}
