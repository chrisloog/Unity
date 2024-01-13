using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject playerExplosionEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            GameObject effect = Instantiate(playerExplosionEffect, transform.position, transform.rotation);
            Destroy(effect, 5);
        }
    }
}
