using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialHealth : MonoBehaviour
{
    public Animator tutorialIdle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void hp()
    {
        tutorialIdle.SetTrigger("Hurt");
        Debug.Log("AHHH, SAKIT!");
    }
}
