using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectAWingControllerScript : MonoBehaviour
{
    private const string selectedAWing = "Selected A-Wing";

    public void SelectedRed(){
        PlayerPrefs.SetInt(selectedAWing, 1);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedResistance(){
        PlayerPrefs.SetInt(selectedAWing, 2);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedWGY(){
        PlayerPrefs.SetInt(selectedAWing, 3);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedWhiteRed(){
        PlayerPrefs.SetInt(selectedAWing, 4);
        SceneManager.LoadScene("LoadingScene");
    }
}
