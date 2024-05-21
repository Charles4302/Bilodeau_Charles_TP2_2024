using System.Collections;
using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;

public class PoubelleManager : MonoBehaviour
{

    [SerializeField] private GameManager gameManager;
    [SerializeField]private CollectableObjects targetCollectableObject;

    private void OnTriggerEnter (Collider other) {
        if (other.CompareTag("Dechet")){
            Collectable collectable = other.GetComponent<Collectable>();
                if (collectable.pickUpObjectType == targetCollectableObject)
                {
                    gameManager.AjoutPoint(10); 
                }
                else
                {
                    gameManager.PertePoint(5); 
                }

        }
        
    }
}
