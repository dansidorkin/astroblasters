using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;
    Vector2 mousePos;
    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");      
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        if (rb.position.x > -10 && rb.position.x < 10 && rb.position.y > -10 && rb.position.y < 10)
        {
            rb.MovePosition(rb.position + movement * Time.fixedDeltaTime * moveSpeed);
        }
        

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90.0f;

        rb.rotation = angle;
    }
}
