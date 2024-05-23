using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionnaireSceneFin : MonoBehaviour
{
    [SerializeField]
    private InfosNiveau infosNiveau;

    [SerializeField]
    private InfosJoueur infosJoueur;
    [SerializeField]

    private TMP_Text champNomJoueur;

    [SerializeField]
    private TMP_Text champScore;

    [SerializeField]
    private TMP_Text champNomEnvironnement;

    [SerializeField]
    private TMP_Text champCauseFinDePartie;

    void Start()
    {
        champNomJoueur.text = infosJoueur.nomJoueur; 
        champNomEnvironnement.text = infosJoueur.nomEnvironnement;
        champScore.text = infosJoueur.score.ToString();
        CauseFinDePartie();
    }

    public void CauseFinDePartie(){

        if(infosNiveau.temps == 0)
        {
            champCauseFinDePartie.text = "Temps ecoule";
        }
        if(infosJoueur.nbrVie == 0)
        {
            champCauseFinDePartie.text = "Vous etes mort d'un accident de voiture";
        }
    }

    
}
