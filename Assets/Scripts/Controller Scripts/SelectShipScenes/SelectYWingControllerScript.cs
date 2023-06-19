using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectYWingControllerScript : MonoBehaviour
{
    private const string selectedYWing = "Selected Y-Wing";

    public void SelectedGold(){
        PlayerPrefs.SetInt(selectedYWing, 1);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedGreenCream(){
        PlayerPrefs.SetInt(selectedYWing, 2);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedMBW(){
        PlayerPrefs.SetInt(selectedYWing, 3);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedPRG(){
        PlayerPrefs.SetInt(selectedYWing, 4);
        SceneManager.LoadScene("LoadingScene");
    }
}
