using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollider : MonoBehaviour
{

    MultiTargetCamera mTC;

    GameObject player1, player2;

    private void Start()
    {
        mTC = FindObjectOfType<MultiTargetCamera>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //mTC.targets.Remove();
            mTC.targets.Clear();
            //mTC.CenterPositionOfCameraOnDeath();
            mTC.isDead = true;
            //Destroy(other.gameObject);
            //other.gameObject
            Debug.Log("Player one is dead");
        }
        if (other.tag == "Player2")
        {
            mTC.targets.Clear();
            //mTC.CenterPositionOfCameraOnDeath();
            mTC.isDead = true;
            //Destroy(other.gameObject);
            Debug.Log("Player two is dead");
        }
    }
}
