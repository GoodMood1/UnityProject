using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public GameObject RestartButton;
    public GameObject RestartButton2;
    public GameObject RestartButton3;
    public void Restartlevel()
    {
        Time.timeScale = 1;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);//если  надо заново

        //След код только если не заново
        RestartButton.SetActive(false);
        RestartButton2.SetActive(false);
        RestartButton3.SetActive(false);
    }
    public void Exittt()
    {
        Application.Quit();
    }
    public void Mi()
    {
        SceneManager.LoadScene("Mission");
        Time.timeScale = 1;
    }
    public void Men()
    {
        SceneManager.LoadScene("Menuu");

        Time.timeScale = 1;

    }
    public void Startt()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
}
}
