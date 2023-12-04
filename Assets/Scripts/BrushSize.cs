using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BrushSize : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public float newSize;
    public int defaultSize = 1;

    public void ChangeSize(float sliderValue)
    {
        newSize = sliderValue;     
        lineRenderer.startWidth = (0.2f * newSize);
        lineRenderer.endWidth = (0.3f * newSize);
    }
}

