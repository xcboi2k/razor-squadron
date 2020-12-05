using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectXWingControllerScript : MonoBehaviour
{
    private const string selectedXWing = "Selected X-Wing";

    public void SelectedIronMan(){
        PlayerPrefs.SetInt(selectedXWing, 1);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedRebellion(){
        PlayerPrefs.SetInt(selectedXWing, 2);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedResistance(){
        PlayerPrefs.SetInt(selectedXWing, 3);
        SceneManager.LoadScene("LoadingScene");
    }

    public void SelectedTFAPoe(){
        PlayerPrefs.SetInt(selectedXWing, 4);
        SceneManager.LoadScene("LoadingScene");
    }
    public void SelectedTROSPoe(){
        PlayerPrefs.SetInt(selectedXWing, 4);
        SceneManager.LoadScene("LoadingScene");
    }
}
