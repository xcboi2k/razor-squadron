using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreenControllerScript : MonoBehaviour
{
    public Slider loadingBar;
    float loadingTime = 0f;

    void Update()
    {
        loadingTime += Time.deltaTime;

        loadingBar.value = loadingTime;

        if(loadingTime >= 20f){
            SceneManager.LoadScene("GameplayScene");
        }

        Debug.Log(loadingTime);
    }
}
