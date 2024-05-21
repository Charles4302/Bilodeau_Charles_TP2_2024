using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int nbrPoint;

    public void AjoutPoint(int points = 10){
        nbrPoint += points;
        Debug.Log("Points: " + points);        
    }

    public void PertePoint(int points = 10){
        nbrPoint -= points;
        Debug.Log("Points: " + points);  
    }
}
