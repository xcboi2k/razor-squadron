using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{       
    public static int movespeed = 7;
    public Vector3 userDirection = Vector3.left;

    void Update()
    {
        transform.Translate(userDirection * movespeed * Time.deltaTime);
        Destroy(gameObject, 4.0f);
    }
}
