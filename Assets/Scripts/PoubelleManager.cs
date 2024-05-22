using System.Collections;
using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PoubelleManager : MonoBehaviour
{

    [SerializeField] private GameManager gameManager;

    [SerializeField]
    private GestionnaireNiveau gestionnaireNiveau;
    [SerializeField]private CollectableObjects targetCollectableObject;
    public UnityEvent jouerSonAjoutPoints;
    public UnityEvent jouerSonPertePoints;

    private void OnTriggerEnter (Collider other) {


        if (other.CompareTag("Dechet")){

            Collectable collectable = other.GetComponent<Collectable>();
                if (collectable.pickUpObjectType == targetCollectableObject)
                {
                    gestionnaireNiveau.AjoutPoint(collectable.pickUpObjectType.point); 
                    jouerSonAjoutPoints.Invoke();
                }
                else
                {
                    gestionnaireNiveau.PertePoint(5); 
                    jouerSonPertePoints.Invoke();
                }

        }
        
    }
}
