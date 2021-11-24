using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUBallsizeMinus : MonoBehaviour
{

    public float multiplier = -2.5f;

    public GameObject pickupEffect;

    public GameObject Bolder_Player1;
    public GameObject Bolder_Player2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))

        {
            Pickup(other);
        }

        else if (other.CompareTag("Player2"))

        {
            Pickup2(other);
        }


    }


    void Pickup(Collider other)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        Bolder_Player1 = GameObject.Find("Bolder_Player2");

        Bolder_Player1.transform.localScale *= multiplier;

        Destroy(gameObject);

    }
    void Pickup2(Collider other)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        Bolder_Player2 = GameObject.Find("Bolder_Player1");

        Bolder_Player2.transform.localScale *= multiplier;

        Destroy(gameObject);

    }




}
