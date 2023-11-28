using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public Button jeda;
    public GameObject panelKalah;
    public GameObject panelMenang;
    public GameObject panelPause;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            jeda.onClick.Invoke();
        }
        if ((panelKalah.activeSelf || panelPause.activeSelf) == true)
        {
            gameObject.SetActive(false);
        }
    }
    public void home()
    {
        SceneManager.LoadScene(0); //balik ke menu
    }
    public void pause()//pause
    {
        Time.timeScale = 0;
    }
    public void play()//play
    {
        Time.timeScale = 1;
    }
    public void restart()
    {
        string sceneNow = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneNow);
    }
}
