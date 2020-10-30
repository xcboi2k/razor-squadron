﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public static PlayerScript instance;
    public bool isAlive;
    private float speed = 5f;
    private float forwardSpeed = 3f;
    public int playerScore;

    public GameObject player;
    public Animator playerAnim;

    public AudioSource playerAudioSource;
    public AudioClip noteClip, laserClip, bombClip, hitClip, explodeClip;

    public GameObject laserPrefab1, laserPrefab2, bombPrefab;
    public GameObject laserHolder1, laserHolder2, bombHolder;

    public Text finalScoreText;
    
    
    void Awake()
    {
        if(instance == null){
            instance = this;
        }

        isAlive = true;
        playerAudioSource.PlayOneShot(noteClip);
        playerScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(isAlive == true){
            Vector3 temp = transform.position;
            temp.x += forwardSpeed * Time.deltaTime;
            transform.position = temp;

            Vector3 movement = new Vector3(0.0f, Input.GetAxis("Vertical"), 0.0f);
            transform.position = transform.position + movement * Time.deltaTime * speed;

            Debug.Log("Player moving");

            fireLaser();
            dropBomb();
        }
        
    }

    private void fireLaser(){
        Vector2 shootingDirection = new Vector2(5,0);

        if(Input.GetButtonDown("Jump")){ //Fire1, Jump
            GameObject laser1 = Instantiate(laserPrefab1, laserHolder1.transform.position, Quaternion.identity);
            GameObject laser2 = Instantiate(laserPrefab1, laserHolder2.transform.position, Quaternion.identity);
            laser1.GetComponent<Rigidbody2D>().velocity = shootingDirection * 10.0f;
            laser2.GetComponent<Rigidbody2D>().velocity = shootingDirection * 10.0f;
            playerAudioSource.PlayOneShot(laserClip);

            Destroy(laser1, 2.0f);
            Destroy(laser2, 2.0f);
            Debug.Log("LASER FIRING");
        }

    }

    private void dropBomb(){
        Vector2 dropDirection = new Vector2(0,-5);

        if(Input.GetButtonDown("Fire1")){
            GameObject bomb = Instantiate(bombPrefab, bombHolder.transform.position, Quaternion.identity);
            bomb.GetComponent<Rigidbody2D>().velocity = dropDirection * 3.0f;
            playerAudioSource.PlayOneShot(bombClip);

            Destroy(bomb, 2.0f);
            Debug.Log("BOMB DROPPED");
        }
    }

    void SetCameraX() {
        CameraScript.offsetX = (Camera.main.transform.position.x - transform.position.x) - 1f;
    }

    public float GetPositionX(){
        return transform.position.x;
    }

    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "Enemy"){
            //Destroy(gameObject);
            playerAudioSource.PlayOneShot(hitClip);
            Debug.Log("Hit an enemy.");

            finalScoreText.text = "" + playerScore;
            
            Destroy(target.gameObject);
            SelfDestruct();

            GameObject.Find("Gameplay Controller").GetComponent<AudioScript>().isAlive = false;
            GameObject.Find("Continue Canvas").GetComponent<ContinueMenuScript>().continueMenu.SetActive(true);
        }    
    }

    private void SelfDestruct(){
        playerAnim.SetTrigger("Dead");
        playerAudioSource.PlayOneShot(explodeClip);
        isAlive = false;
        GameObject.Find("Spawn Controller").GetComponent<SpawnControllerScript>().spawnAllowed = false;
    }
}
