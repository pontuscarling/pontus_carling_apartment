using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public GameObject artCanvas;
    public GameObject player;
    public float smoothSpeed = 1f;
    public Vector3 offset;
    

    private void Start()
    {
        artCanvas = GameObject.Find("ArtCanvas");
        player = GameObject.Find("Player");
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

    public void StartPainting()
    {        
        target = artCanvas.transform;
        offset = new Vector3(5f, 0f, 0f);
        gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        offset.Set(5, 0, 0);
        
    }
    public void QuitPainting()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            target = player.transform;
            offset = new Vector3(5f, 4f, -5f);
            gameObject.transform.rotation = Quaternion.Euler(25f, -45f, 0f);
            offset.Set(5, 4, -5);
        }
    }
}

