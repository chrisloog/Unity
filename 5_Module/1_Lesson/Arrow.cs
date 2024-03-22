using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject arrow;

    public float speed = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(arrow, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Enemy enemy = other.GetComponent<Enemy>();
            enemy.TakeDamage();
        }

        Destroy(gameObject);
    }

}