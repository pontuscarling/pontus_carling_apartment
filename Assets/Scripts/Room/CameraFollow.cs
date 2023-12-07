using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;    
    public GameObject player;
    public GameObject draw;
    public GameObject paintCanvas;
    public Rigidbody rb;
    public float smoothSpeed = 1f;
    public Vector3 offset;
    

    private void Start()
    {        
        Time.timeScale = 1f;
        player = GameObject.Find("Player");
        rb = player.GetComponent<Rigidbody>();
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
        draw.SetActive(true);
        paintCanvas.SetActive(true);
        rb.isKinematic = true;
        //followScript.offset.Set(0 , 0, 0);
    }
    public void QuitPainting()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            draw.SetActive(false);
            paintCanvas.SetActive(false);
            rb.isKinematic = false;
            //followScript.offset.Set(0, -2, 0);
        }
    }
}

