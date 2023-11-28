using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject slime;
    public int panggilan;
    // Start is called before the first frame update
    void Start()
    {
        panggilan = 0;
        InvokeRepeating("Spawn", 0f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        if(panggilan < 10)
        {
            Instantiate(slime, transform.position, Quaternion.identity);
        }
        panggilan++;
    }
}
