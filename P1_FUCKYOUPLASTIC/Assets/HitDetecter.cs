using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetecter : MonoBehaviour
{
    public string otherTagToDetect;
    public GameManager gm;
    public bool isPlayerOne;
    Rigidbody rb;
    public float addForceSpeed = 10000f;
    BoatMove bm;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == otherTagToDetect)
        {
            if (isPlayerOne)
            {
                gm.DamagePlayer2();
                Debug.Log("HitPlayer2");
                bm = collision.gameObject.GetComponent<BoatMove>();
                bm.isMoving = false;
                rb = collision.gameObject.GetComponent<Rigidbody>();
                rb.AddForce(transform.up * addForceSpeed);

                StartCoroutine(Delay());

            }
            else
            {
                gm.DamagePlayer1();
                Debug.Log("HitPlayer1");
                bm = collision.gameObject.GetComponent<BoatMove>();
                bm.isMoving = false;
                rb = collision.gameObject.GetComponent<Rigidbody>();
                rb.AddForce(transform.up * addForceSpeed);

                StartCoroutine(Delay());
            }
        }
    }


    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2f);
        bm.isMoving = true;
    }
}
