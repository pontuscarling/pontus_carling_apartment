using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{
    private CameraFollow camerafollow;

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
    /*
    public void InteractionRadiio()
    {

    }
    public void InteractionPlant()
    {

    }
    public void InteractionComputer()
    {

    }
    */
}
