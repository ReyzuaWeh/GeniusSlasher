using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cDisplay : MonoBehaviour
{
    public Camera main;
    public Camera question1;
    public Canvas cq1;
    public Camera question2;
    public Canvas cq2;
    public Camera question3;
    public Canvas cq3;
    public Camera question4;
    public Canvas cq4;
    public Camera question5;
    public Canvas cq5;
    // Start is called before the first frame update
    void Start()
    {
        main.enabled = true;
        question1.enabled = false;
        question2.enabled = false;
        question3.enabled = false;
        question4.enabled = false;
        question5.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if(main.enabled)
            {
                main.enabled = false;
                question1.enabled = true;
                question2.enabled = false;
                question3.enabled = false;
                question4.enabled = false;
                question5.enabled = false;
            }
            else
            {
                main.enabled = true;
                question1.enabled = false;
                question2.enabled = false;
                question3.enabled = false;
                question4.enabled = false;
                question5.enabled = false;
            }
        }
    }
}
