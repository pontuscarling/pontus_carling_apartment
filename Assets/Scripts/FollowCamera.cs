using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public float targetDistance = 5f;
    public Vector3 offset;
    

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0,-2,0);
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 FollowPosition = target.position + (target.forward + offset) * targetDistance;
        transform.position = FollowPosition;
    }
}
