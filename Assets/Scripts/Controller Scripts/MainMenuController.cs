using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject infoPanel;

    public void PlayGame(){
        SceneManager.LoadScene("ControlScene");
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void OpenInfo(){
        infoPanel.SetActive(true);
    }

    public void CloseInfo(){
        infoPanel.SetActive(false);
    }
}
