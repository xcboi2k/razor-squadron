using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource gameplayAudioSource;
    
    public bool isAlive;
    // Start is called before the first frame update
    void Awake()
    {
        isAlive = true;
        gameplayAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isAlive == false){
            gameplayAudioSource.Stop();
        }
    }
}
