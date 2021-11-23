using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScriptAJ : MonoBehaviour
{
    // Start is called before the first frame update

    public float jumpVelocity = 10f;
    // Hvor højt en character kan hoppe

    public float distance2Ground = 0.1f;
    // Hvor langt fra jorden en character skal være for at hoppe

    public LayerMask groundLayer;

    private float _vInput;
    private float _hInput;
    private Rigidbody _rb;

    private CapsuleCollider _col;


    void Start()
    {

        _rb = GetComponent<Rigidbody>();
        // Det er den rigidbody som sqriptet sidder på man definere, som i dette tilfælde er _rb

        _col = GetComponent<CapsuleCollider>();


    }

    // Update is called once per frame


    private void Update()

    {

        if (isGrounded() && Input.GetKeyDown(KeyCode.J))
        {

            _rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);

        }

      

    }

    private bool isGrounded()
    {

        Vector3 capsuleBottom = new Vector3(_col.bounds.center.x, _col.bounds.min.y, _col.bounds.center.z);

        bool grounded = Physics.CheckCapsule(_col.bounds.center,capsuleBottom, distance2Ground, groundLayer, QueryTriggerInteraction.Ignore);


        return grounded;
    }

}
