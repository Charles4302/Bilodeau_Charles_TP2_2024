using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAudioSetting : MonoBehaviour
{
    public bool GameIsPaused = false;

    public GameObject infosAudio;

    public GameObject player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            if (GameIsPaused)
            {
                Resume();
            } else if (!GameIsPaused)
            {
                Pause();
            }
            PlayerControl();
        }
    }

    public void Resume(){
        infosAudio.SetActive(false);
        GameIsPaused = false;
    }

    public void Pause(){
        infosAudio.SetActive(true);
        GameIsPaused = true;
    }

    public void PlayerControl(){
        if (GameIsPaused)
            {
                player.SetActive(false);
            }
            else
            {
                player.SetActive(true);
            }
    }

    public void CloseMenu(){
        infosAudio.SetActive(false);
        player.SetActive(true);
    }
}
