using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CoinsCollector coinsCollector = other.GetComponent<CoinsCollector>();

        coinsCollector.CollectCoins();

        Destroy(gameObject);
    }
}
