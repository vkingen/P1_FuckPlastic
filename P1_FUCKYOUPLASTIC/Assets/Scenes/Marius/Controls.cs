using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour

{
    public LayerMask groundLayer;

    public float distance2Ground = 0.1f;
    public float jumpVelocity = 5f;
    public float moveSpeed = 10f;

    public bool isPlayerOne;
    public bool isMoving = true;

    private float vInput;
    private float hInput;

    private Rigidbody rb;
    private BoxCollider col;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<BoxCollider>();
    }

    private bool isGrounded()
    {
        Vector3 boxBottom = new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z);

        bool grounded = Physics.CheckCapsule(col.bounds.center, boxBottom, distance2Ground, groundLayer, QueryTriggerInteraction.Ignore);

        return grounded;
    }
    private void Update()
    {
        Debug.Log(isMoving);
        if (isPlayerOne)
        {
            if (isMoving)
            {
                float horizontal = Input.GetAxis("Horizontal");
                float vertical = Input.GetAxis("Vertical");

                rb.velocity = new Vector3(horizontal * moveSpeed, rb.velocity.y, vertical * moveSpeed);

                if (isGrounded() && Input.GetButtonDown("Jump"))
                {
                    rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
                }
            }
        }
        else
        {
            if (isMoving)
            {
                float horizontal = Input.GetAxis("Horizontal2");
                float vertical = Input.GetAxis("Vertical2");
                rb.velocity = new Vector3(horizontal * moveSpeed, rb.velocity.y, vertical * moveSpeed);

                if (isGrounded() && Input.GetButtonDown("Jump2"))
                {

                    rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);

                }
            }
        }
    }
}
