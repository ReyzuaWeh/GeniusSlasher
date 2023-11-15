using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class userHpUI : MonoBehaviour
{
    public Slider healthSlider;
    public Text hpUI;
    public Image health;
    public GameObject user;
    public GameObject UI;
    public Gradient gradien;
    public float screenPembanding = 1920f;
    public float hpMax;
    public float hpNow;
    // Start is called before the first frame update
    void Start()
    {
        hpMax = user.GetComponent<hp>().hitpoin;
    }

    // Update is called once per frame
    void Update()
    {
        hpNow = user.GetComponent<hp>().hitpoin;
        healthSlider.value = hpNow / hpMax;
        
        float hasil= hpNow / hpMax * 100;
        hpUI.text = hasil.ToString() +"%";
        health.color = gradien.Evaluate(healthSlider.normalizedValue); 
    }
    void adjustUI()
    {
        float scaleFactor = Screen.width / screenPembanding;
    }
}
