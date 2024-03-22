using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    public float shootInterval = 0.75f;
    public float shootTimer = 0;
    public GameObject arrowPrefab;
    
    void Update()
    {
        if (shootTimer > 0)
        {
            shootTimer -= Time.deltaTime;
        }

        Vector2 mouseScreenPos = Input.mousePosition;

        Vector2 mouseScenePos = Camera.main.ScreenToWorldPoint(mouseScreenPos);

        Vector2 bowPos = transform.position;

        Vector2 wantedDirection = mouseScenePos;

        Vector2 defaultDirection = Vector2.up;

        float angle = Vector2.SignedAngle(defaultDirection, wantedDirection);

        Vector3 newEuler = new Vector3(bowPos.x, bowPos.y, angle);

        transform.localEulerAngles = newEuler;
        
        if (Input.GetMouseButton(0))
        {
            if (shootTimer <= 0)
            {
                Instantiate(arrowPrefab, transform.position, transform.rotation);
                shootTimer = shootInterval;
            }

        }

    }
}