using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class Obstacle : MonoBehaviour
{
    public GameObject RestartButton;
    public GameObject RestartButton2;
    public GameObject RestartButton3;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.GetComponent<Bird>())
        {
            //SceneManager.LoadScene("SampleScene");
            Time.timeScale = 0;
            RestartButton.SetActive(true);
            RestartButton2.SetActive(true);
            RestartButton3.SetActive(true);

        }
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.GetComponent<Bird>())
        {
            //SceneManager.LoadScene("SampleScene");
            Time.timeScale = 0;
            RestartButton.SetActive(true);
            RestartButton2.SetActive(true);
            RestartButton3.SetActive(true);
        }
    }
}
