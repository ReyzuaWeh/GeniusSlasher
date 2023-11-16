using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offsetArea : MonoBehaviour
{
    private BoxCollider2D bc;
    public LayerMask allowedLayers;
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // Periksa apakah objek lain memiliki lapisan yang diizinkan
        if (other.gameObject.layer < 9)
        {
            Debug.Log("Objek lain diizinkan melewati.");
            bc.isTrigger = true;
        }
        else
        {
            bc.isTrigger = false;
            // Objek lain tidak memiliki lapisan yang diizinkan, hindari melewati
            Debug.Log("Player tidak diizinkan melewati.");
            // Tambahkan kode lain untuk menanggapi ketika player mencoba melewati objek ini
        }
    }
}

