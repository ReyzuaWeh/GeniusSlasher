using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
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
}
