using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    public float timer;
    public Text timerText;
    HeroKnight user;
    // Start is called before the first frame update
    void Start()
    {
        user = GetComponent<HeroKnight>();
    }

    // Update is called once per frame
    void Update()
    {
        cd();
        timerText.text = timer.ToString("0");
    }
    public void cd()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }else if (timer <= 0)
        {
            timer = 0;
            user.normal();
        }
    }
}
