using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;
    private float inputX;
    private float inputY;
    private Vector2 vector2;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void PlayerInput()
    {
        // if (inputY == 0)        
        inputX = Input.GetAxisRaw("Horizontal");
        // if (inputX == 0)
        inputY = Input.GetAxisRaw("Vertical");
        if (inputX != 0 && inputY != 0) {
            inputX *= 0.6f;
            inputY *= 0.6f;
        }

        vector2 = new Vector2(inputX, inputY);
    }

    private void Movement()
    {
        rb.MovePosition(rb.position + vector2 * speed * Time.deltaTime);
    }

    private void Update() {
        PlayerInput();
    }
  
    void FixedUpdate()
    {
        Movement();
    }
}
