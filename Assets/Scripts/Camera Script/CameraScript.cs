using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public static float offsetX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerScript.instance != null){
            if(PlayerScript.instance.isAlive){
                MoveCamera();
            }
        }
    }

    void MoveCamera(){
        Vector3 temp  = transform.position;
        temp.x = PlayerScript.instance.GetPositionX() + offsetX;
        transform.position = temp;
    }
}
