using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsMenuControllerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame(){
        SceneManager.LoadScene("GameplayScene");
    }
}
