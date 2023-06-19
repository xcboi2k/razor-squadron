using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "Enemy"){

            GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().score += 10;
            GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().finalScore += 10;
            Destroy(gameObject);

            GameObject.Find("EnemySound Controller").GetComponent<EnemySoundControllerScript>().PlayAudio();
            Destroy(target.gameObject, 0.2f);
            Debug.Log("Bomb hit an enemy.");
        }    
    }
}
