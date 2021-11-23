using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour

{
    public LayerMask groundLayer;

    public float distance2Ground = 0.1f;
    public float jumpVelocity = 5f;
    public float moveSpeed = 10f;

    private float vInput;
    private float hInput;

    private Rigidbody rb;
    private CapsuleCollider col;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
    }

    private bool isGrounded()
    {
        Vector3 capsuleBottom = new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z);

        bool grounded = Physics.CheckCapsule(col.bounds.center, capsuleBottom, distance2Ground, groundLayer, QueryTriggerInteraction.Ignore);

        return grounded;
    }


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontal * moveSpeed, rb.velocity.y, vertical * moveSpeed);

        if (isGrounded() && Input.GetKeyDown(KeyCode.J))
        {

            rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);

        }

    }

}
