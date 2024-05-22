using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionnaireSceneFin : MonoBehaviour
{
    [SerializeField]
    private InfosJoueur infosJoueur;
    [SerializeField]

    private TMP_Text champNomJoueur;

    [SerializeField]
    private TMP_Text champScore;

    [SerializeField]
    private TMP_Text champNomEnvironnement;
    void Start()
    {
        champNomJoueur.text = infosJoueur.nomJoueur; 
        champNomEnvironnement.text = infosJoueur.nomEnvironnement;
        champScore.text = infosJoueur.score.ToString();
    }

    
}
