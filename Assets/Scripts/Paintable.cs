using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintable : MonoBehaviour
{
    public GameObject brush;
    public Camera renderCamera;
    public float brushSize = 0.00001f;
    public Vector3 offset;
    public RenderTexture rTexture;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            renderCamera.enabled = true;
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(Ray, out hit))
            {
                var go = Instantiate(brush, hit.point + offset, Quaternion.LookRotation(gameObject.transform.position), transform);
                go.transform.localScale = Vector3.one * brushSize;
            }
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
        var texture2D = new Texture2D(rTexture.width, rTexture.height);
        texture2D.ReadPixels(new Rect(0,0, rTexture.width, rTexture.height),0,0);
        texture2D.Apply();
    }

}
