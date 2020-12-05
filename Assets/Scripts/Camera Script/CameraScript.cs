using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public static float offsetX;

    private const string selectedShip = "Selected Ship";

    void Update()
    {
        int getShip = PlayerPrefs.GetInt(selectedShip);
        switch(getShip){
            case 1://X-Wing
                if (XWingScript.instance != null){
                    if(XWingScript.instance.isAlive){
                    MoveCamera();
                    }
                }
                break;
            case 2://A-Wing
                if (AWingScript.instance != null){
                    if(AWingScript.instance.isAlive){
                    MoveCamera();
                    }
                }
                break;
            case 3://Y-WIng
                if (YWingScript.instance != null){
                    if(YWingScript.instance.isAlive){
                    MoveCamera();
                    }
                }
                break;
            case 4://MAAT
                if (MAATScript.instance != null){
                    if(MAATScript.instance.isAlive){
                    MoveCamera();
                    }
                }
                break;
        }
        
    }

    void MoveCamera(){
        Vector3 temp  = transform.position;

        int getShip = PlayerPrefs.GetInt(selectedShip);
        switch(getShip){
            case 1://X-Wing
                temp.x = XWingScript.instance.GetPositionX() + offsetX;
                break;
            case 2://A-Wing
                temp.x = AWingScript.instance.GetPositionX() + offsetX;
                break;
            case 3://Y-WIng
                temp.x = YWingScript.instance.GetPositionX() + offsetX;
                break;
            case 4://MAAT
                temp.x = MAATScript.instance.GetPositionX() + offsetX;
                break;
        }

        transform.position = temp;
    }
}
