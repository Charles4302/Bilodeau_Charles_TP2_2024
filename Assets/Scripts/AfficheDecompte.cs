using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class AfficheDecompte : MonoBehaviour
{
    [SerializeField]
    private InfosNiveau infosNiveau;

    [SerializeField]
    private TMP_Text champsTexteTemps;

    public void AfficheTemps(){

        float temps = infosNiveau.temps;

        if (temps < 0){
            temps = 0;
        }

        TimeSpan ts = TimeSpan.FromSeconds(temps);

        champsTexteTemps.text = string.Format("{1:00}: {2:00}", ts.Minutes, ts.Seconds);
    }
}
