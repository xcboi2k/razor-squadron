using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject playButton;
    public void PlayGame(){
        SceneManager.LoadScene("ControlScene");
    }

    public void QuitGame(){
        Application.Quit();
    }
}
