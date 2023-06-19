using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText, finalScoreText;

    public int score, finalScore;

    public bool stopCountingScore;

    private const string selectedShip = "Selected Ship";

    private const string XWingHighScore = "X-Wing High Score";
    private const string AWingHighScore = "A-Wing High Score";
    private const string YWingHighScore = "Y-Wing High Score";
    private const string MAATHighScore = "MAAT High Score";

    void Start() {
        stopCountingScore = false;
    }
    void Update(){
        if(stopCountingScore == false){
            scoreText.text = "" + score;
        }

        else{
            finalScoreText.text = "" + finalScore;
            int getSelectedShip  = PlayerPrefs.GetInt(selectedShip);

            int getXWingHighScore = PlayerPrefs.GetInt(XWingHighScore);
            int getAWingHighScore = PlayerPrefs.GetInt(AWingHighScore);
            int getYWingHighScore = PlayerPrefs.GetInt(YWingHighScore);
            int getMAATHighScore = PlayerPrefs.GetInt(MAATHighScore);

            if(getSelectedShip == 1){
                if(finalScore > getXWingHighScore){
                    PlayerPrefs.SetInt(XWingHighScore, finalScore);
                }
            }
            else if(getSelectedShip == 2){
                if(finalScore > getAWingHighScore){
                    PlayerPrefs.SetInt(AWingHighScore, finalScore);
                }
            }

            else if(getSelectedShip == 3){
                if(finalScore > getYWingHighScore){
                    PlayerPrefs.SetInt(YWingHighScore, finalScore);
                }
            }

            else if(getSelectedShip == 4){
                if(finalScore > getMAATHighScore){
                    PlayerPrefs.SetInt(MAATHighScore, finalScore);
                }
            }
        }
    }
}
