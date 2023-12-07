using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public LineRenderer linerenderer;
    Color startColor;
    Color endColor;


    private void Start()
    {
        startColor = Color.red;
        endColor = new Color(240, 0, 0);        
    }        
    public void switchRed()
    {
        startColor = Color.red;
        endColor = new Color(220,0,0);
        linerenderer.startColor = startColor;
        linerenderer.endColor = endColor;

    }
    public void switchGreen()
    {
        startColor = Color.green;
        endColor = new Color(0,220,0);
        linerenderer.startColor = startColor;
        linerenderer.endColor = endColor;
    }
    public void switchBlue()
    {
        startColor = Color.blue;
        endColor = new Color(0, 0, 220);
        linerenderer.startColor = startColor;
        linerenderer.endColor = endColor;
    }
    public void switchYellow()
    {
        startColor = Color.yellow;
        endColor = Color.yellow;
        linerenderer.startColor = startColor;
        linerenderer.endColor = endColor;
    }
    public void switchWhite()
    {
        startColor = Color.white;
        endColor = Color.white;
        linerenderer.startColor = startColor;
        linerenderer.endColor = endColor;
    }
    public void switchBlack()
    {
        startColor = Color.black;
        endColor = Color.black;
        linerenderer.startColor = startColor;
        linerenderer.endColor = endColor;
    }
}
