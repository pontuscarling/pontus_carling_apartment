using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public CameraFollow camerafollow;

    private void Start()
    {
        camerafollow = GameObject.Find("Main Camera").GetComponent<CameraFollow>();
    }
    public void InteractionArtStation()
    {
        camerafollow.StartPainting();
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
