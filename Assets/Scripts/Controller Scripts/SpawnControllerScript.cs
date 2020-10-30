using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControllerScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyTIE;
    int randomSpawnPoint, randomTIE;
    public bool spawnAllowed;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnAShip", 0f, 1f);    
    }

    // Update is called once per frame
    void SpawnAShip()
    {
        if (spawnAllowed){
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomTIE = Random.Range(0, enemyTIE.Length);
            Instantiate (enemyTIE[randomTIE], spawnPoints [randomSpawnPoint].position, Quaternion.identity);
        }
    }
}
