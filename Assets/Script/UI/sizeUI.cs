using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizeUI : MonoBehaviour
{
    public RectTransform pauseUI;
    public RectTransform timerUI;
    public RectTransform hpUI;
    public RectTransform pauseMenuUI;
    private float scaleFactor;
    private float screenPembanding = 800f;

    // Start is called before the first frame update
    void Start()
    {
        scaleFactor = Screen.width / screenPembanding;
        pauseJustifySize();
        hpJustifySize();
        timerJustifySize();
        pauseMenuSize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void pauseJustifySize()
    {
        pauseUI.sizeDelta = new Vector2(pauseUI.sizeDelta.x * scaleFactor, pauseUI.sizeDelta.y * scaleFactor);
    }
    void hpJustifySize()
    {
        hpUI.sizeDelta = new Vector2(hpUI.sizeDelta.x * scaleFactor, hpUI.sizeDelta.y * scaleFactor);
    }
    void timerJustifySize()
    {
        timerUI.sizeDelta = new Vector2(timerUI.sizeDelta.x * scaleFactor, timerUI.sizeDelta.y * scaleFactor);
    }
    void pauseMenuSize()
    {
        pauseMenuUI.sizeDelta = new Vector2(pauseMenuUI.sizeDelta.x * scaleFactor, pauseMenuUI.sizeDelta.y * scaleFactor);
    }

}
