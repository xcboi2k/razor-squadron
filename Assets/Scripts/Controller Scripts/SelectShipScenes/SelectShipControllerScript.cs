using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectShipControllerScript : MonoBehaviour
{
    public GameObject XWing, AWing, YWing, MAAT;

    public GameObject ClickArrowsInfo;

    public Text highScoreText;

    private int characterInt = 1;

    private const string selectedShip = "Selected Ship";

    private const string XWingHighScore = "X-Wing High Score";
    private const string AWingHighScore = "A-Wing High Score";
    private const string YWingHighScore = "Y-Wing High Score";
    private const string MAATHighScore = "MAAT High Score";

    public void NextCharacter(){
        ClickArrowsInfo.SetActive(false);

        int getXWingHighScore = PlayerPrefs.GetInt(XWingHighScore);
        int getAWingHighScore = PlayerPrefs.GetInt(AWingHighScore);
        int getYWingHighScore = PlayerPrefs.GetInt(YWingHighScore);
        int getMAATHighScore = PlayerPrefs.GetInt(MAATHighScore);

        switch(characterInt)
        {
            case 1://X-Wing
                PlayerPrefs.SetInt(selectedShip, 1);
                highScoreText.text = "" + getXWingHighScore;
                MAAT.SetActive(false);
                XWing.SetActive(true);
                characterInt++;
                break;
            case 2://A-Wing
                PlayerPrefs.SetInt(selectedShip, 2);
                highScoreText.text = "" + getAWingHighScore;
                XWing.SetActive(false);
                AWing.SetActive(true);
                characterInt++;
                break;
            case 3://Y-Wing
                PlayerPrefs.SetInt(selectedShip, 3);
                highScoreText.text = "" + getYWingHighScore;
                AWing.SetActive(false);
                YWing.SetActive(true);
                characterInt++;
                break;
            case 4://MAAT
                PlayerPrefs.SetInt(selectedShip, 4);
                highScoreText.text = "" + getMAATHighScore;
                YWing.SetActive(false);
                MAAT.SetActive(true);
                characterInt++;
                ResetInteger();
                break;
            default:
                ResetInteger();
                break;
        }
    }

    public void PreviousCharacter(){
        ClickArrowsInfo.SetActive(false);

        int getXWingHighScore = PlayerPrefs.GetInt(XWingHighScore);
        int getAWingHighScore = PlayerPrefs.GetInt(AWingHighScore);
        int getYWingHighScore = PlayerPrefs.GetInt(YWingHighScore);
        int getMAATHighScore = PlayerPrefs.GetInt(MAATHighScore);

        switch(characterInt)
        {
            case 1://MAAT
                PlayerPrefs.SetInt(selectedShip, 4);
                highScoreText.text = "" + getMAATHighScore;
                XWing.SetActive(false);
                MAAT.SetActive(true);
                characterInt--;
                ResetInteger();
                break;
            case 2://X-Wing
                PlayerPrefs.SetInt(selectedShip, 1);
                highScoreText.text = "" + getXWingHighScore;
                AWing.SetActive(false);
                XWing.SetActive(true);
                characterInt--;
                break;
            case 3://A-Wing
                PlayerPrefs.SetInt(selectedShip, 2);
                highScoreText.text = "" + getAWingHighScore;
                YWing.SetActive(false);
                AWing.SetActive(true);
                characterInt--;
                break;  
            case 4://Y-Wing
                PlayerPrefs.SetInt(selectedShip, 3);
                highScoreText.text = "" + getYWingHighScore;
                MAAT.SetActive(false);
                YWing.SetActive(true);
                characterInt--;
                break;  
            default:
                ResetInteger();
                break;
        }
    }

    private void ResetInteger(){
        if(characterInt >= 4){
            characterInt = 1;
        }
        else{
            characterInt = 4;
        }
    }

    public void Select(){
        int getShip = PlayerPrefs.GetInt(selectedShip);

        if(getShip == 1){//X-Wing
            SceneManager.LoadScene("SelectXWingScene");
        }

        else if(getShip == 2){//A-Wing
            SceneManager.LoadScene("SelectAWingScene");
        }

        else if(getShip == 3){//Y-Wing
            SceneManager.LoadScene("SelectYWingScene");
        }

        else if(getShip == 4){//MAAT
            SceneManager.LoadScene("SelectMAATScene");
        }
    }
}
