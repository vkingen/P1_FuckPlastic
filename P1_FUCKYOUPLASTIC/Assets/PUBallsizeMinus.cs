using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUBallsizeMinus : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }



    }   


    void Pickup()
    {
        Debug.Log("Ballsize minimized!");
    }












}
