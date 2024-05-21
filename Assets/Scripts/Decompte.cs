using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Decompte : MonoBehaviour
{

    [SerializeField]
    private InfosNiveau infosNiveau;

    private bool decompteActif = false;

    public UnityEvent auChangementDuTemps;
    public UnityEvent aLaFinDuTemps;


    // Start is called before the first frame update
    void Start()
    {
        DemarrerDecompte();
    }

    // Update is called once per frame
    void Update()
    {
        if (decompteActif){

            if(infosNiveau.temps > 0){
                infosNiveau.temps -= Time.deltaTime;
                auChangementDuTemps.Invoke();
            }
            else{
                infosNiveau.temps = 0;
                decompteActif = false;
                aLaFinDuTemps.Invoke();
            }

        }
    }

    public void DemarrerDecompte(){
        infosNiveau.temps = infosNiveau.tempsInitial;
        decompteActif = true;
    }

}
