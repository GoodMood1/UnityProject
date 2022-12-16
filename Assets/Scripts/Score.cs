﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    public int score;
    public Text scoret;
    void Start()
    {
        score = 0;
    }
    void Update()
    {
        scoret.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Score")
        {
            score++;
        }
        if (score == 20)
        {
            SceneManager.LoadScene("Win");
            Time.timeScale = 1;
        }
    }
}

