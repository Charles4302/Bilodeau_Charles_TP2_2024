using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PerdVie : MonoBehaviour
{
    private int nbrVie = 3;

    public UnityEvent jouerSonPerteVie;
    
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            nbrVie --;
            jouerSonPerteVie.Invoke();
            if(nbrVie == 0)
            {
                gameManager.ChangementSceneFin();
            }
            
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
