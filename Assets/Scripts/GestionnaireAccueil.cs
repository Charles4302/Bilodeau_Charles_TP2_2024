using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GestionnaireAccueil : MonoBehaviour
{
    [SerializeField]
    private InfosJoueur infosJoueur;

    [SerializeField]
    private TMP_InputField champNomJoueur;

    [SerializeField]
    private TMP_InputField champNomEnvironnement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangementTexte(string nom){
        infosJoueur.nomJoueur = nom;
        
    }

    public void ChangementTexteEnvironnement(string nom){
        infosJoueur.nomEnvironnement = nom;
    }

    public void ChangementScene()
    {
        if (infosJoueur.nomJoueur != "" && infosJoueur.nomEnvironnement != ""){
            SceneManager.LoadScene("Jeu");
        }
        
    }
}
