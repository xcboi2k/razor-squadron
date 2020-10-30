using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySoundControllerScript : MonoBehaviour
{
    public AudioSource enemyAudioSource;
    public AudioClip explodeClip;
    // Start is called before the first frame update
    public void PlayAudio(){
        enemyAudioSource.PlayOneShot(explodeClip);
    }
}
