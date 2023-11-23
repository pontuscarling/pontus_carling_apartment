using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] tracks;
    public AudioSource vinylPlayerAudioSource;
    bool MusicPlaying;


    public void SelectTrack(int step)
    {
        AudioClip clip = tracks[step];   
        if (MusicPlaying)
        {
            vinylPlayerAudioSource.PlayOneShot(clip);
        }
        if(step < 0)
        {
            step = 2;
        }
        else if (step > 2)
        {
            step = 0;
        }
    }
   
    public void PlayMusic(bool playing)
    {
        if (playing)
        {
            MusicPlaying = true;
            Debug.Log("MusicPlaying = true");
        }
    }
}