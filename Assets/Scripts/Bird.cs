using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speedx = 14f;
    public float speedy = 8f;
    private Rigidbody2D rbb;
    public GameObject RestartButton;
    public GameObject RestartButton2;
    public GameObject RestartButton3;
    void Start()
    {
        rbb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rbb.velocity = new Vector2(0f, speedy);
        }
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.tag == "Enemy")
        {
            //SceneManager.LoadScene("SampleScene");
            Time.timeScale = 0;
            RestartButton.SetActive(true);
            RestartButton2.SetActive(true);
            RestartButton3.SetActive(true);
        }
    }
}
