using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has a CoinsCounter component
        CoinsCounter coinsCounter = other.GetComponent<CoinsCounter>();

        if (coinsCounter != null)
        {
            // Increment the coin count
            coinsCounter.CollectCoins();

            // Destroy the coin GameObject
            Destroy(gameObject);
        }
    }
}