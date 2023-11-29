using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnKecil : MonoBehaviour
{
    public int panggilan;
    public GameObject slime;
    GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        panggilan = 0;
        InvokeRepeating("spawnnya", 0f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnnya()
    {
        if (panggilan < 2)
        {
            enemy = Instantiate(slime, transform.position + new Vector3(0f, Random.Range(1f, 3f)), Quaternion.identity);
            enemy.SetActive(true);
            panggilan++;
        }
    }
}
