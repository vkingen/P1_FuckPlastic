using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamOnTrigger : MonoBehaviour
{
    AudioSource aS;

    private void Start()
    {
        aS = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Player2")
        {
            aS.Play();
            Debug.Log("PLAY AUDIO");
        }
        Debug.Log("swagger");
    }
}
