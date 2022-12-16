using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuLoad : MonoBehaviour
{
    public GameObject RestartButton;
    public void Men()
    {
        SceneManager.LoadScene("Menuu");
        Time.timeScale = 1;

    }
}
