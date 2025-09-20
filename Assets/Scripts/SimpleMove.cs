// File: SimpleMoveRB.cs
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SimpleMove : MonoBehaviour
{
    public float speed = 5f; // h�z (Inspector'dan ayarla)
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.gravityScale = 0f; // z�plamay�/yer�ekimini kapat�r
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal"); // -1,0,1
        Vector2 vel = new Vector2(h * speed, rb.linearVelocity.y);
        rb.linearVelocity = vel;
    }
}

