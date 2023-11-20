using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cDisplay : MonoBehaviour
{
    public Camera main;
    public Camera question1;
    // Start is called before the first frame update
    void Start()
    {
        main.enabled = true;
        question1.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if(main.enabled)
            {
                question1.enabled = true;
                main.enabled = false;
            }
            else
            {
                question1.enabled = false;
                main.enabled = true;
            }
        }
    }
}
