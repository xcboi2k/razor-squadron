using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSpawnerControllerScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] razorSquadronShips;
    int randomSpawnPoint, randomShips;
    public bool spawnAllowed;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnAShip", 0.5f, 1f);    
    }

    // Update is called once per frame
    void SpawnAShip()
    {
        if (spawnAllowed){
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomShips = Random.Range(0, razorSquadronShips.Length);
            Instantiate (razorSquadronShips[randomShips], spawnPoints [randomSpawnPoint].position, Quaternion.identity);
        }
    }
}
