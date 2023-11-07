using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class buff : MonoBehaviour
{
    public GameObject user;
    public float timer;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D buff)
    {
        if (buff.gameObject.CompareTag("BM"))//buff merah
        {
            Destroy(buff.gameObject);
            user.GetComponent<HeroKnight>().dmgBuff();
        }
    }
}
