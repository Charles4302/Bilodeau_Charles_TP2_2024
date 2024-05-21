using System.Collections;
using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PoubelleManager : MonoBehaviour
{

    [SerializeField] private GameManager gameManager;
    [SerializeField]private CollectableObjects targetCollectableObject;
    public UnityEvent jouerSonAjoutPoints;
    public UnityEvent jouerSonPertePoints;

    private void OnTriggerEnter (Collider other) {
        if (other.CompareTag("Dechet")){
            Collectable collectable = other.GetComponent<Collectable>();
                if (collectable.pickUpObjectType == targetCollectableObject)
                {
                    gameManager.AjoutPoint(10); 
                    jouerSonAjoutPoints.Invoke();
                }
                else
                {
                    gameManager.PertePoint(5); 
                    jouerSonPertePoints.Invoke();
                }

        }
        
    }
}
