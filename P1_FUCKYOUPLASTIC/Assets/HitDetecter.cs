using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetecter : MonoBehaviour
{
    public string otherTagToDetect;
    public GameManager gm;
    public bool isPlayerOne;
    public float addForceSpeed = 10000f;
    BoatMove bm;

    AudioSource aS;

    public float delayTimeForPlayerMovement = 0.5f;


    private void Start()
    {
        aS = GetComponent<AudioSource>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "Ball")
        //{
        //    // Calculate Angle Between the collision point and the player
        //    Vector3 dir = collision.contacts[0].point - transform.position;
        //    // We then get the opposite (-Vector3) and normalize it
        //    dir = -dir.normalized;
        //    // And finally we add force in the direction of dir and multiply it by force. 
        //    // This will push back the player
        //    collision.gameObject.GetComponent<Rigidbody>().AddForce(dir * addForceSpeed);
        //    Debug.Log("ballhit");
        //}

        if (collision.gameObject.tag == otherTagToDetect)
        {
            if (isPlayerOne)
            {
                gm.DamagePlayer2();
                aS.Play();
                bm = collision.gameObject.GetComponent<BoatMove>();
                //bm.enabled = false;
                bm.isMoving = false;
                //collision.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * addForceSpeed);
                
                // Calculate Angle Between the collision point and the player
                Vector3 dir = collision.contacts[0].point - transform.position;
                // We then get the opposite (-Vector3) and normalize it
                dir = -dir.normalized;
                // And finally we add force in the direction of dir and multiply it by force. 
                // This will push back the player
                collision.gameObject.GetComponent<Rigidbody>().AddForce(dir * addForceSpeed);

                StartCoroutine(Delay());

            }
            else
            {
                gm.DamagePlayer1();
                aS.Play();
                bm = collision.gameObject.GetComponent<BoatMove>();
                //bm.enabled = false;
                bm.isMoving = false;
                //collision.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * addForceSpeed);

                // Calculate Angle Between the collision point and the player
                Vector3 dir = collision.contacts[0].point - transform.position;
                // We then get the opposite (-Vector3) and normalize it
                dir = -dir.normalized;
                // And finally we add force in the direction of dir and multiply it by force. 
                // This will push back the player
                collision.gameObject.GetComponent<Rigidbody>().AddForce(dir * addForceSpeed);

                StartCoroutine(Delay());
            }
        }
    }
    

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(delayTimeForPlayerMovement);
        //bm.enabled = false;
        bm.isMoving = true;
    }
}
