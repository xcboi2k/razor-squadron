using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript instance;
    [SerializeField] public Text scoreText;

    public int score = 0;
    public int finalScore;

    void Update(){
        scoreText.text = "" + score;
    }
    //public void ShowScore(int score){
    //    if(GameObject.Find("Player").GetComponent<PlayerScript>().isAlive == false){
    //        finalScore = ScoreScript.instance.score;
    //    }
    //}
}
