using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offsetArea : MonoBehaviour
{
    private BoxCollider2D bc;
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.layer);
        // Periksa apakah objek lain memiliki lapisan yang diizinkan
        if (other.gameObject.layer < 6)
        {
            Debug.Log("Objek selain enemy dilarang");
            bc.isTrigger = false;
        }
        else
        {
            bc.isTrigger = true;
            // Objek lain tidak memiliki lapisan yang diizinkan, hindari melewati
            Debug.Log("Enemy diizinkan");
            // Tambahkan kode lain untuk menanggapi ketika player mencoba melewati objek ini
        }
    }
}

