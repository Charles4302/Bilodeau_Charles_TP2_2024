using UnityEngine;
using TMPro;

public class GestionnaireNiveau : MonoBehaviour
{
    [SerializeField]
    private InfosJoueur infosJoueur;
    
    [SerializeField]
    private TMP_Text champNomJoueur;

    [SerializeField]
    private TMP_Text champNomEnvironnement;

    // Start is called before the first frame update
    void Start()
    {
        champNomJoueur.text = infosJoueur.nomJoueur; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
