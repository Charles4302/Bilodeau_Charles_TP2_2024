using UnityEngine;
using TMPro;

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

    // Start is called before the first frame update
    void Start()
    {
        champNomJoueur.text = infosJoueur.nomJoueur; 
        champNomEnvironnement.text = infosJoueur.nomEnvironnement;
    }

    public void PickObject(Component sender, object data){
        Debug.Log("Je reçois des données: " + data);
    }
}
