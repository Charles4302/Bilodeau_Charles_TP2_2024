using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAttackChien : MonoBehaviour
{

    [SerializeField] private GameObject chien;

    [SerializeField] private GameObject joueur;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            chien.GetComponent<Animator>().SetBool("Attack", true );
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            chien.GetComponent<Animator>().SetBool("Attack", false);
        }
    }
}
