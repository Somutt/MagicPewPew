using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    public float enemySpeed;
    private Rigidbody2D rb;

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
        if ((transform.position.x < -2.3 && enemySpeed < 0) || (transform.position.x > 2.3 && enemySpeed > 0)) {
            enemySpeed *= -1;
        }
    }

}
