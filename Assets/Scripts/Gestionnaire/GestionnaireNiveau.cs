using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class GestionnaireNiveau : MonoBehaviour
{
    [SerializeField]
    private InfosJoueur infosJoueur;
    
    [SerializeField]
    private TMP_Text champNomJoueur;

    [SerializeField]
    private TMP_Text champScore;

    [SerializeField]
    private TMP_Text champNomEnvironnement;

    [SerializeField]
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        champNomJoueur.text = infosJoueur.nomJoueur; 
        champNomEnvironnement.text = infosJoueur.nomEnvironnement;
        infosJoueur.score = 0;
    }


    public void AjoutPoint(int points){
        infosJoueur.score += points;
        Debug.Log("Points: " + points);
        champScore.text = infosJoueur.score.ToString();
    }

    public void PertePoint(int points){
        infosJoueur.score -= points;
        Debug.Log("Points: " + points);
        champScore.text = infosJoueur.score.ToString();
    }

     public void AfficherPoints(){
       champScore.text = infosJoueur.score.ToString();
     }

    public void PickObject(Component sender, object data){
        Debug.Log("Je reçois des données: " + data);
    }
}
