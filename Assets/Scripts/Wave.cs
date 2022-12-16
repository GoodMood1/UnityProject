using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public float speedx = 0f;
    private float dy;
    void Start()
    {
        dy = Random.Range(-2.73f, 2.73f);
        transform.position = new Vector3(transform.position.x, transform.position.y + dy, transform.position.z);
    }
    void Update()
    {
        transform.position = new Vector3(transform.position.x-speedx*Time.deltaTime, transform.position.y, transform.position.z);
    }

}
