using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // NPC health
    public int health = 5;

    // NPC level
    public int level = 1;

    // NPC speed
    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        // Add NPC level to health
        health += level;

        print("Player health: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current position of the NPC
        Vector3 newPosition = transform.position;

        // Update the position along the Z-axis based on speed and time
        newPosition.z += speed * Time.deltaTime;

        // Update the NPC's position
        transform.position = newPosition;
    }
}
