using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed = 6;
    private PointManager pointManager;

    private void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Enemy") 
        { 
            Destroy(collision.gameObject);
            pointManager.UpdateScore(50);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Boundaries")
        {
            Destroy(gameObject);
        }
    }
}
