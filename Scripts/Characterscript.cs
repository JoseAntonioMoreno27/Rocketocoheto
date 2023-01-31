using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characterscript : MonoBehaviour
{

    public float velocity = 1;
    public ControladorEscenaScr controladorEscena;
    private Rigidbody2D rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0))    // Main and only mechanic is pressing the screen, I used GetMouseButton because it later gets translated to a phone environment 
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)  // to detect if the character has touch a pipe therefore lost the run 
    {
        controladorEscena.Gameover();
    }
}
