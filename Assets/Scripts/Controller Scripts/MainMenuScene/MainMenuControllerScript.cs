using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControllerScript : MonoBehaviour
{
    public GameObject controlsPanel;

    public void PlayGame(){ 
        SceneManager.LoadScene("SelectShipScene");
    }

    public void ExitGame(){
        Application.Quit();
    }

    public void OpenControls(){
        controlsPanel.SetActive(true);
    }

    public void ExitControls(){
        controlsPanel.SetActive(false);
    }
}
