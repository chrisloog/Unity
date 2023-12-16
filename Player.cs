using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int points;
    public Projectile projectilePrefab;
    public float shootInterval;
    public float shootTimer;
 
    void Shoot()
    {
        if(shootTimer <= 0)
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            shootTimer = shootInterval;
        }

    }


    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = realPos;
        }
    }

    void Update()
    {
        Move();
        Shoot();
        shootTimer -= Time.deltaTime;
    }
}
