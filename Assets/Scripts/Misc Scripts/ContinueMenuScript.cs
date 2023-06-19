using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContinueMenuScript : MonoBehaviour
{
    public GameObject continueMenu;
    
    public void continueGame(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("SelectShipScene");
    }

    public void LoadMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenuScene");
    }
}