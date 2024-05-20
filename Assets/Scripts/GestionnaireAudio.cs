using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GestionnaireAudio : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audioMixer;

    [SerializeField]
    private AudioClip sonFXT;
    
    private AudioSource audioSource;

    private void Start(){
        audioSource = GetComponent<AudioSource>();
    }

    public void AjusteVolumeMusique(float volume){
        audioMixer.SetFloat("VolumeMusique", volume);
    }

    public void AjusteVolumeEffets(float volume){
        audioMixer.SetFloat("VolumeEffets", volume);
    }

    public void VolumeEffets(){
        audioSource.PlayOneShot(sonFXT);
    }

    public void VolumeSons2D(float volume){
        audioMixer.SetFloat("VolumeSons2D", volume);
    }

    public void VolumeSons3D(float volume){
        audioMixer.SetFloat("VolumeSons3D", volume);
    }
}
