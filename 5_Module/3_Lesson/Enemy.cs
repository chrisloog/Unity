using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    public float speed = 1f;

    float borderPosX;

    public Animator animator;

    public float attackInterval = 1f;
    public float attackTimer = 0;

    public float speedPerLevel = 0.2f;
 
    void Start()
    {
        speed += speedPerLevel * LevelController.level;
        borderPosX = Corn.singleton.transform.position.x;
    }
    
    void Update () {
        float enemyPosX = transform.position.x;

        if (attackTimer > 0)
        {
            attackTimer -= Time.deltaTime;
        }

        if (enemyPosX > borderPosX)
        {
            transform.position += -transform.right * speed * Time.deltaTime;
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
            if (attackTimer <= 0)
            {
                Attack();
                attackTimer = attackInterval;
            }
        }
    }

 
    public void TakeDamage()
    {
        health -= 1;
 
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Attack()
    {
        Corn.singleton.TakeDamage();
    }


}