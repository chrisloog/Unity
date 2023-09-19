using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public bool isActive;

    // Update is called once per frame
    void Update()
    {
        if (isActive) {
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlatformStop") {
            direction *= -1;
        } else if (other.tag == "Player") {
            isActive = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            isActive = false;
        }
    }
}
