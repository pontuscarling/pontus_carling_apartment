using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VinylPlayer : MonoBehaviour
{
    public Camera cam;
    public Transform albums;
    public Rigidbody rb;
    public int songIndex = 0;
    public float albumPosition;
    public float speed = 0.15f;
    public Vector3 offset;
    

    private void Start()
    {
        offset.Set(970, 560, 0);
    }
    private void Update()
    {
        //FUL LÖSNING MED OFFSET!!!!! FIXA SÅ ATT WORLDTOSCREEN FUNGERAR!
        TransformWorldToScreenSpace(albums.position);
        
        Vector3 transition = Vector3.Lerp(albums.position, offset, speed);
        albums.position = transition;
        

        QuitVinylPlayer();
        
    }

    private void TransformWorldToScreenSpace(Vector3 worldPos)
    {
        Vector3 screenPos = cam.WorldToScreenPoint(worldPos);
    }

    public void SongPicker(int step)
    {
        songIndex += step;
        Debug.Log("songindex: " + songIndex);

        if (songIndex > 2)
        {
            songIndex = 0;
        }
        else if (songIndex < 0)
        {
            songIndex = 2;
        }
        if (songIndex == 0) 
        { 
            albumPosition = 0;
            offset.Set(albumPosition + 970, 560, 0);
            Debug.Log("pos 0");
        }
        else if(songIndex == 1)
        {
            albumPosition = -1280f;
            offset.Set(albumPosition + 970, 560, 0);
            Debug.Log("pos 1");
        }
        else if(songIndex == 2)
        {
            albumPosition = -2560f;
            offset.Set(albumPosition + 970, 560, 0);
            Debug.Log("pos 2");
        }  
    }

    private void QuitVinylPlayer()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(false);
            rb.isKinematic = false;
        }
    }
}
