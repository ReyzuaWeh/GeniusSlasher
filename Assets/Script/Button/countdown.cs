using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    public float timer;
    public Text timerText;
    public GameObject user;
    public GameObject panelWin;
    public GameObject panelLose;
    GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Enemy = GameObject.FindGameObjectWithTag("slime");
        if(user.GetComponent<hp>().hitpoin <= 0)
        {
            timerText.text = string.Empty;
        }
        else
        {
            cd();
            timerText.text = timer.ToString("0");
        }
        if(timerText.text == "0")
        {
            timerText.text = string.Empty;
        }
    }
    public void cd()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }else if (timer <= 0 && Enemy == null)
        {
            timer = 0;
            timerText.text = string.Empty;
            panelWin.SetActive(true);
            if (user.GetComponent<HeroKnight>().dahNormal == false)
            {
                user.GetComponent<HeroKnight>().normal();
            }
            Time.timeScale = 0;
        }else if(timer <= 0)
        {
            timer = 0;
            timerText.text = string.Empty;
            panelLose.SetActive(true);
            if (user.GetComponent<HeroKnight>().dahNormal == false)
            {
                user.GetComponent<HeroKnight>().normal();
            }
            Time.timeScale = 0;
        }
    }

}
