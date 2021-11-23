using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMove : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody rb;
    public bool isPlayerOne;
    public bool isMoving = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Debug.Log(isMoving);
        if(isPlayerOne)
        {
            if(isMoving)
            {
                float horizontal = Input.GetAxis("Horizontal");
                float vertical = Input.GetAxis("Vertical");
                rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, vertical * speed);
            }
            
        }
        else
        {
            if(isMoving)
            {
                float horizontal = Input.GetAxis("Horizontal2");
                float vertical = Input.GetAxis("Vertical2");
                rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, vertical * speed);
            }
            
        }
    }
}
