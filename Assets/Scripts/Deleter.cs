using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deleter : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Wave>()){
            Destroy(other.gameObject);
        }
    }
}
