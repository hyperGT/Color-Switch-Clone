using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float jumpForce = 10f;

    public Rigidbody2D rb;
    
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
