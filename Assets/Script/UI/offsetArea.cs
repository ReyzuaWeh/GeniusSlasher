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
        if (other.gameObject.layer < 6)
        {
            Debug.Log("Objek lain diizinkan melewati.");
            bc.isTrigger = false;
        }
        else
        {
            bc.isTrigger = true;
            // Objek lain tidak memiliki lapisan yang diizinkan, hindari melewati
            Debug.Log("Player tidak diizinkan melewati.");
            // Tambahkan kode lain untuk menanggapi ketika player mencoba melewati objek ini
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer > 6)
        {
            Debug.Log("ditutup");
            bc.isTrigger = false;
        }
    }
}

