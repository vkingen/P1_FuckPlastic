using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUballsizePlus : MonoBehaviour
{
        public GameObject pickupEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"));

        {
            Pickup();

        }
    }


    void Pickup()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);




        Destroy(gameObject);
    }
}
