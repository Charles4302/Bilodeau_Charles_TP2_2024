using System.Collections;
using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;

public class JeterDechet : MonoBehaviour
{

    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject dechet;

    private void OnTriggerEnter (Collider other) {
        if (other.CompareTag("Poubelle")){
            
            Destroy(dechet);

        }
        
    }
}
