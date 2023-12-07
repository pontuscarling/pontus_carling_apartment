using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{
    private CameraFollow camerafollow;
    public GameObject vinylPlayer;
    public Rigidbody rb;
    [HideInInspector]public GameObject lamp;
    new bool light = false;

    private void Start()
    {
        camerafollow = GameObject.Find("Main Camera").GetComponent<CameraFollow>();        
    }
    public void InteractionArtStation()
    {
        camerafollow.StartPainting();       
    }
    public void InteractionArcade()
    {
        SceneManager.LoadScene("VideoGame");
    }
    public void InteractionMusic()
    {
        vinylPlayer.SetActive(true);
        rb.isKinematic = true;
    }    
    public void InteractionLights()
    {
        if (light)
        {
            light = false;
            lamp.SetActive(false);
        }
        else
        {
            light = true;
            lamp.SetActive(true);
        }
    }
    
}
