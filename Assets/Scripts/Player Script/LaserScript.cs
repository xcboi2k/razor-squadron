using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{  
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "Enemy"){
            GameObject.Find("Gameplay Controller").GetComponent<ScoreScript>().score += 10;
            GameObject.Find("Player").GetComponent<PlayerScript>().playerScore += 10;
            Destroy(gameObject);

            GameObject.Find("EnemySound Controller").GetComponent<EnemySoundControllerScript>().PlayAudio();
            Destroy(target.gameObject);
            Debug.Log("Laser hit an enemy.");
        }    
    }
}
