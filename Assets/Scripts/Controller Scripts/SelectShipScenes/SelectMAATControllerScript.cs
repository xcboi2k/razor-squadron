using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMAATControllerScript : MonoBehaviour
{
    private const string selectedMAAT = "Selected MAAT";

    public void SelectedBurntOrange(){
        PlayerPrefs.SetInt(selectedMAAT, 1);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedMarineBlue(){
        PlayerPrefs.SetInt(selectedMAAT, 2);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedMossGreen(){
        PlayerPrefs.SetInt(selectedMAAT, 3);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedRed(){
        PlayerPrefs.SetInt(selectedMAAT, 4);
        SceneManager.LoadScene("LoadingScene");
    }
}
