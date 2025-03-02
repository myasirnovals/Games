using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRigidbody2D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Mengecek apakah sudah ada Rigidbody2D, jika belum, tambahkan
        if (gameObject.GetComponent<Rigidbody2D>() == null)
        {
            Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D>();

            // Konfigurasi awal Rigidbody2D
            rb.gravityScale = 1;  // Mengatur efek gravitasi
            rb.mass = 1;          // Mengatur massa
            rb.freezeRotation = true;  // Mencegah rotasi akibat benturan
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
