using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMove : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody rb;
    public bool isPlayerOne;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(isPlayerOne)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, vertical * speed);
        }
        else
        {
            float horizontal = Input.GetAxis("Horizontal2");
            float vertical = Input.GetAxis("Vertical2");
            rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, vertical * speed);
        }
    }
}
