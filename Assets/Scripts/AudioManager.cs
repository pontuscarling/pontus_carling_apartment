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
        index += step;
        if(step < 0)
        {
            step = 2;
        }
        else if (step > 2)
        {
            step = 0;
        }

        Debug.Log("Index: " + index);
        clip = tracks[index];
    }
   
    public void PlayMusic()
    {
        
        if (!musicPlaying)
        {
            Debug.Log("MusicPlaying = true");
            vinylPlayerAudioSource.clip = tracks[index];
            //AudioClip clip = tracks[index];
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