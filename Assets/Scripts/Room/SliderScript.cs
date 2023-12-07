using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public GameObject brushPrefab;
    public Slider slider;

    void Update()
    {
        brushPrefab.GetComponent<BrushSize>().ChangeSize(slider.value);
        Debug.Log(slider.value);
    }
}
