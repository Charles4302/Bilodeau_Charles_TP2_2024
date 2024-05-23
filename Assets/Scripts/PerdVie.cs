using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PerdVie : MonoBehaviour
{
    [SerializeField]
    private InfosJoueur infosJoueur;

    public UnityEvent jouerSonPerteVie;
    
    public GameManager gameManager;

    void Start()
    {
        infosJoueur.nbrVie = 3;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            jouerSonPerteVie.Invoke();
            GameObject coeur1 = GameObject.FindGameObjectWithTag("Coeur 1");
            GameObject coeur2 = GameObject.FindGameObjectWithTag("Coeur 2");
            GameObject coeur3 = GameObject.FindGameObjectWithTag("Coeur 3");

            if(infosJoueur.nbrVie == 3){
                infosJoueur.nbrVie --;
                coeur1.SetActive(false);
            }
            else if(infosJoueur.nbrVie == 2){
                infosJoueur.nbrVie --;
                coeur2.SetActive(false);
            }
            else if(infosJoueur.nbrVie == 1){
                infosJoueur.nbrVie --;
                coeur3.SetActive(false);
            }

            if(infosJoueur.nbrVie == 0)
            {
                gameManager.ChangementSceneFin();
            }

        }
        
    }

}
