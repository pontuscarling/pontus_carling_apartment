using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;    
    public GameObject player;
    public GameObject artCanvas;
    public FollowCamera followScript;
    public float smoothSpeed = 1f;
    public Vector3 offset;
    

    private void Start()
    {
        
        player = GameObject.Find("Player");
        followScript = GameObject.Find("ArtCanvas").GetComponent<FollowCamera>();
        target = player.transform;
        offset.Set(5, 4, -5);
    }
    void Update()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
 
        QuitPainting();
    }

    //flytta dessa funktioner till eget script!!!!!!! 
    public void StartPainting()
    {
        artCanvas.SetActive(true);
        //followScript.offset.Set(0 , 0, 0);
    }
    public void QuitPainting()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            artCanvas.SetActive(false);
            //followScript.offset.Set(0, -2, 0);
        }
    }
}

