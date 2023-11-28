using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cDisplay : MonoBehaviour
{
    public Camera main;
    public Canvas mainCanvas;
    public Camera question1;
    public Canvas cq1;
    public GameObject TNPC;

    public int siBenar;
    // Start is called before the first frame update
    void Start()
    {
        main.enabled = true;
        mainCanvas.enabled = true;
        question1.enabled = false;
        cq1.enabled = false;
    }

    // Update is called once per frame
    public void pertanyaan()
    {
        if (main.enabled)
        {
            main.enabled = false;
            mainCanvas.enabled = false;
            question1.enabled = true;
            cq1.enabled = true;
        }
    }
    public void pertanyaanBeres()
    {
        if (!main.enabled)
        {
            main.enabled = true;
            mainCanvas.enabled = true;
            question1.enabled = false;
            cq1.enabled = false;
            if (TNPC != null)
            {
                TNPC.GetComponent<introTrade>().sudahBeres();
            }
        }
    }
}
