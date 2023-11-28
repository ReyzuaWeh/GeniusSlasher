using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject slime;
    public int panggilan;
    private GameObject enemy;
    public GameObject Enemy
    {
        get { return enemy; }
        private set { enemy = value; }
    }
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
    public void spawn()
    {
        if(panggilan < 10)
        {
            enemy = Instantiate(slime, transform.position, Quaternion.identity);
            enemy.SetActive(true);
        }
        panggilan++;
    }

}
