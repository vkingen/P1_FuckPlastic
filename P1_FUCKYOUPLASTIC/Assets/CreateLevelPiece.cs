using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLevelPiece : MonoBehaviour
{
    public float waitTime;
    public GameObject tileToSpawn;
    public GameObject[] tilesToSpawn;

    public Transform spawnLocation;
    private void Start()
    {
        
        Instantiate(tilesToSpawn[Random.Range(0,tilesToSpawn.Length)], spawnLocation.position, Quaternion.identity);
        StartCoroutine(CreateWithDelay());
    }
    IEnumerator CreateWithDelay()
    {
        yield return new WaitForSeconds(waitTime);
        Instantiate(tilesToSpawn[Random.Range(0, tilesToSpawn.Length)], spawnLocation.position, Quaternion.identity);
        StartCoroutine(CreateWithDelay());
    }
}
