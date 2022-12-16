using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public float period = 1f;
    private float pretime = 0f;
    [SerializeField] GameObject wavepref;
    [SerializeField] Bird brd;
    void Start()
    {
        pretime = Time.time - period * 2f;
    }
    void Update()
    {
        if (Time.time - pretime >= period)
        {
            GameObject wp = Instantiate(wavepref, transform);
            wp.GetComponent<Wave>().speedx = brd.speedx;
            pretime = Time.time;
        }
    }
}
