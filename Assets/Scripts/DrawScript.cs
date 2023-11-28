using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawScript : MonoBehaviour
{
    public Camera cam;
    public GameObject brush;
    LineRenderer lineRenderer;
    Vector2 lastPos;
    public bool isPainting = true;

    private void Update()
    {
        if (isPainting) 
        {
            Draw();
        }
        
    }
    public void Draw()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreateBrush();
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            if (mousePos != lastPos)
            {
                AddPoint(mousePos);
                lastPos = mousePos;
            }            
        }
        else
        {
            lineRenderer = null;
        }
    }
    public void CreateBrush()
    {
        GameObject brushInstance = Instantiate(brush);
        lineRenderer = brushInstance.GetComponent<LineRenderer>();

        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        lineRenderer.SetPosition(0, mousePos);
        lineRenderer.SetPosition(1, mousePos);
    }
    public void AddPoint(Vector2 pointPos)
    {
        lineRenderer.positionCount++;
        int positionIndex = lineRenderer.positionCount - 1;
        lineRenderer.SetPosition(positionIndex, pointPos);
    }
}
