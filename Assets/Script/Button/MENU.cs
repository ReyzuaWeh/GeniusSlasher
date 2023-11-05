using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }
    public void exit()//tombol exit, WAJIB PUBLIC agar dapat diakses
    {
        Debug.Log("AKU KELUAR!");
        Application.Quit();
    }
    public void tutorial()
    {
        SceneManager.LoadScene("Tutorial");//tutorial
    }

    public void lvl1()//lvl1
    {
        SceneManager.LoadScene("LVL1");
    }
    public void lvl2()//lvl2
    {
        SceneManager.LoadScene("LVL2");
    }
    public void lvl3()//lvl3
    {
        SceneManager.LoadScene("LVL3");
    }
}
