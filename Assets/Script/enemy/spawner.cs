using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject slime;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        Instantiate(slime, transform.position, Quaternion.identity);
    }
}
