using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public float targetDistance = 5f;
    public Vector3 offset;

    void Start()
    {
        offset = new Vector3(0,-2,0);
    }

    void Update()
    {
        Vector3 FollowPosition = target.position + (target.forward + offset) * targetDistance;
        transform.position = FollowPosition;
    }
}
