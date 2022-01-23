using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    private Rigidbody2D rb;
    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    public float speed;

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        moveLeft = false;
        moveRight = false;

    }

    public void PonterDownLeft() {
        moveLeft = true;
    }

    public void PointerUpLeft() {
        moveLeft = false;
    }

    public void PointerDownRight() {
        moveRight = true;
    }

    public void PointerUpRight() {
        moveRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
    }

    private void FixedUpdate() {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }

    private void MovementPlayer() {
        if(moveLeft) {
            horizontalMove = -speed;
        } else if(moveRight) {
            horizontalMove = speed;
        } else {
            horizontalMove = 0;
        }
    }
}
