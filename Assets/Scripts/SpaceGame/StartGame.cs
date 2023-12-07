using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    
    public GameObject startPanel;

    private void Start()
    {
        Time.timeScale = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        { 
            StartArcade();
        }
    }

    private void StartArcade()
    {
        Time.timeScale = 1.0f;
        startPanel.SetActive(false);       
    }
}
