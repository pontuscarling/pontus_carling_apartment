using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintable : MonoBehaviour
{
    public GameObject brush;
    public Camera paintCamera;
    public Camera renderCamera;
    public float brushSize = 0.00001f;
    public Vector3 offset;
    public RenderTexture rTexture;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            renderCamera.enabled = true;            
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Save();
            Debug.Log("Sparar textur");
            renderCamera.enabled = false;
        }
    }
    public void Save()
    {
        StartCoroutine(CoSave());
    }
    private IEnumerator CoSave()
    {
        yield return new WaitForEndOfFrame();
        RenderTexture.active = rTexture;
        Texture2D texture2D = new Texture2D(rTexture.width, rTexture.height);
        texture2D.ReadPixels(new Rect(0,0, rTexture.width, rTexture.height),0,0);        
        texture2D.Apply();
        
    }

}
