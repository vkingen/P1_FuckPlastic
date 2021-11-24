using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSpawner : MonoBehaviour
{
    public string playerTag;
    public GameObject blood;
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == playerTag) 
        {
            Debug.Log("Spawn");
            Instantiate(blood, transform.position, Quaternion.identity);
        }
    }
}
