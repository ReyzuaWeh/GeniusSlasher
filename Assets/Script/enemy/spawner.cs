using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject slime;
    public int panggilan;
    private GameObject enemy;
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
    public void Spawn()
    {
        if(panggilan < 10)
        {
            enemy = Instantiate(slime, transform.position + new Vector3(0f, Random.Range(1f,3f)), Quaternion.identity);
            enemy.SetActive(true);
        }
        panggilan++;
    }

}
