using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public RectTransform UIpause;
    private float screenPembanding = 800f;
    void Start()
    {
        float scaleFactor = Screen.width / screenPembanding;
        UIpause.sizeDelta = new Vector2(UIpause.sizeDelta.x * scaleFactor, UIpause.sizeDelta.y * scaleFactor);
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
}
