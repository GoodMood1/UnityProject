using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float llevel = 0f;
    void Update()
    {
        transform.position = new Vector3(transform.position.x-llevel, transform.position.y, transform.position.z);
    }
}
