using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintable : MonoBehaviour
{
    public GameObject brush;
    public float brushSize = 0.00001f;
    public Vector3 offset;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(Ray, out hit))
            {
                var go = Instantiate(brush, hit.point + offset, Quaternion.LookRotation(gameObject.transform.position), transform);
                go.transform.localScale = Vector3.one * brushSize;
            }
        }
    }
}
