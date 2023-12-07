using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] tracks;
    public AudioClip clip;
    public AudioSource vinylPlayerAudioSource;
    bool musicPlaying;
    int index;


    public void SelectTrack(int step)
    {
        if(step < 0)
        {
            step = 2;
        }
        else if (step > 2)
        {
            step = 0;
        }
        index += step;
        if (index < 0)
        {
            index = 2;
        }
        else if (index > 2)
        {
            index = 0;
        }
        Debug.Log("Index: " + index + "step: " + step);
        clip = tracks[index];
    }
   
    public void PlayMusic()
    {        
        if (!musicPlaying)
        {            
            vinylPlayerAudioSource.clip = tracks[index];            
            vinylPlayerAudioSource.Play(0);
            musicPlaying = true;
            Debug.Log("Spelar musik");
        }
        else 
        {
            vinylPlayerAudioSource.Pause();
            Debug.Log("Musik pausad");
            musicPlaying = false;
        }
    }
}