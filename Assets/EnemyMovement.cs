using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    public float enemySpeed;
    private Rigidbody2D rb;
    public float changeDirectionTime;
    private float nextDirectionChange;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovementEnemy();
    }

    private void FixedUpdate() {
        rb.velocity = new Vector2(enemySpeed, rb.velocity.y);
    }

    private void MovementEnemy() {
        if (Time.time >= nextDirectionChange) {
            nextDirectionChange = Time.time + changeDirectionTime;
            enemySpeed *= -1;
        }
    }

}
