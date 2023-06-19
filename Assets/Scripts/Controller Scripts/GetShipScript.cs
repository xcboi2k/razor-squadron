using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetShipScript : MonoBehaviour
{
    public GameObject[] XWings, AWings, YWings, MAATs;

    private const string selectedShip = "Selected Ship";

    private const string selectedXWing = "Selected X-Wing";
    private const string selectedAWing = "Selected A-Wing";
    private const string selectedYWing = "Selected Y-Wing";
    private const string selectedMAAT = "Selected MAAT";
    
    void Start()
    {
        int getShip = PlayerPrefs.GetInt(selectedShip);

        if(getShip == 1){//X-Wing
            SelectedXWing();
        }

        else if(getShip == 2){//A-Wing
            SelectedAWing();
        }

        else if(getShip == 3){//Y-Wing
            SelectedYWing();
        }

        else if(getShip == 4){//MAAT
            SelectedMAAT();
        }
    }

    private void SelectedXWing(){
        int getXWing = PlayerPrefs.GetInt(selectedXWing);

        if(getXWing == 1){//IronMan
            XWings[0].SetActive(true);
        }

        else if(getXWing == 2){//Rebellion
            XWings[1].SetActive(true);
        }

        else if(getXWing == 3){//Resistance
            XWings[2].SetActive(true);
        }

        else if(getXWing == 4){//TFAPoe
            XWings[3].SetActive(true);
        }

        else if(getXWing == 4){//TROSPoe
            XWings[4].SetActive(true);
        }
    }

    private void SelectedAWing(){
        int getAWing = PlayerPrefs.GetInt(selectedAWing);

        if(getAWing == 1){//Red
            AWings[0].SetActive(true);
        }

        else if(getAWing == 2){//Resistance
            AWings[1].SetActive(true);
        }

        else if(getAWing == 3){//WGY
            AWings[2].SetActive(true);
        }

        else if(getAWing == 4){//WhiteRed
            AWings[3].SetActive(true);
        }
    }

    private void SelectedYWing(){
        int getYWing = PlayerPrefs.GetInt(selectedYWing);

        if(getYWing == 1){//Gold
            YWings[0].SetActive(true);
        }

        else if(getYWing == 2){//GreenCream
            YWings[1].SetActive(true);
        }

        else if(getYWing == 3){//MBW
            YWings[2].SetActive(true);
        }

        else if(getYWing == 4){//PRG
            YWings[3].SetActive(true);
        }
    }

    private void SelectedMAAT(){
        int getMAAT = PlayerPrefs.GetInt(selectedMAAT);

        if(getMAAT == 1){//BurntOrange
            MAATs[0].SetActive(true);
        }

        else if(getMAAT == 2){//MarineBlue
            MAATs[1].SetActive(true);
        }

        else if(getMAAT == 3){//MossGreen
            MAATs[2].SetActive(true);
        }

        else if(getMAAT == 4){//Red
            MAATs[3].SetActive(true);
        }
    }

}
