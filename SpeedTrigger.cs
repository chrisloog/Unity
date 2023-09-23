using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
   public float speedFactor = 4.0f;

   void OnTriggerEnter(Collider other) {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
   }

   void OnTriggerExit(Collider other) {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
   }
}
