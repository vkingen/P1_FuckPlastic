using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUspeedMinus : MonoBehaviour
{


    public float multiplier = 3f;
    public float originalSpeed = 5.0f;

    public GameObject pickupEffect;

    public GameObject Player;
    public GameObject Player2;

    public int timer = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))

        {
            StartCoroutine(Pickup(other));
        }

        else if (other.CompareTag("Player2"))

        {
            StartCoroutine(Pickup2(other));
        }


    }


    IEnumerator Pickup(Collider other)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        GameObject Player = GameObject.Find("Player2");

        BoatMove BoatMove = Player2.GetComponent<BoatMove>();
        BoatMove.speed -= 5f;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(timer);


        BoatMove.speed = originalSpeed;


        Destroy(gameObject);

    }
    IEnumerator Pickup2(Collider other)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        GameObject Player2 = GameObject.Find("Player");

        BoatMove BoatMove = Player.GetComponent<BoatMove>();
        BoatMove.speed -= 5f;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(timer);


        BoatMove.speed = originalSpeed;


        Destroy(gameObject);

    }


}
