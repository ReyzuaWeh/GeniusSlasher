using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class introTrade : MonoBehaviour
{
    public Text timer;
    // Start is called before the first frame update
    void Start()
    {
        timer.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void ditanya()
    {
        timer.gameObject.SetActive(true);
    }
}
