using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(transform.position, transform.forward, out hitInfo, 2f);
            Debug.DrawRay(transform.position, transform.forward, Color.red, 1);

            if (hit)
            {
                Interactable interactable;
                hitInfo.transform.TryGetComponent<Interactable>(out interactable);

                if (interactable != null)
                {
                    interactable.InteractionArtStation();
                }
                else
                {
                    Debug.Log("Not interactable");
                }
            }
        }
    }
}