using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public GameObject explosion;
    public float speed = 10f;

    void Start()
    {
        Destroy(gameObject, 1f);
    }

    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.up * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle")
        {
            Destroy(collision.gameObject);
            GameObject effect = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(effect, 5);
            Destroy(this.gameObject);
        }
    }

}
