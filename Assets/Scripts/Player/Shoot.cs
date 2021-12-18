using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform firePoint;
    public GameObject projectile;
    public float bulletSpeed;
    public float cooldown;
    private float nextFireTime;

    void Update() {
        if (Input.touchCount > 0) {
            if (Input.GetTouch(0).phase == TouchPhase.Began) {
                Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                Vector2 dir = touchPosition - (new Vector2(transform.position.x, transform.position.y));
                
                if(touchPosition.y > firePoint.position.y && Time.time >= nextFireTime) {
                dir.Normalize();
                GameObject bullet = Instantiate(projectile, firePoint.position, firePoint.rotation);
                bullet.GetComponent<Rigidbody2D>().velocity = dir * bulletSpeed;
                nextFireTime = Time.time + cooldown;
                }
            }
        }
    }
}
