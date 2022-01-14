using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int health;
    public float respawnTime;
    public GameObject enemyRef;
    public Transform spawnPoint;

    private void OnTriggerEnter2D(Collider2D other) {
        

        if (other.CompareTag("projectile")) {
            Score.instance.AddPoints(3);
            Destroy(other.gameObject);
            health--;

            if (health <= 0) {
                gameObject.SetActive(false);
                Invoke("Respawn", respawnTime);
            }

        } 
    }

    void Respawn() {
        GameObject newEnemy = (GameObject) Instantiate(enemyRef, spawnPoint.position, spawnPoint.rotation);

        Destroy(gameObject);
    }

}
