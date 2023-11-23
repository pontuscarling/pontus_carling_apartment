using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{
    private CameraFollow camerafollow;
    public GameObject vinylPlayer;

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
    }
    /*public void InteractionPlant()
    {

    }
    public void InteractionComputer()
    {

    }
    */
}
