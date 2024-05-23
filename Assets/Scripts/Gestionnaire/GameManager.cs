using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{

    public void ChangementScene()
    {
            SceneManager.LoadScene("Accueil");
    }

    public void ChangementSceneFin(){
        SceneManager.LoadScene("SceneFin");
    }

}
