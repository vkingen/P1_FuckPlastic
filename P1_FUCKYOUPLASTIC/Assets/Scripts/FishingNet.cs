using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingNet : MonoBehaviour
{
    LineRenderer lR;
    public Transform player1, player2;

    private void Start()
    {
        lR = GetComponent<LineRenderer>();
        lR.startColor = Color.black;
        lR.endColor = Color.black;
        lR.startWidth = 0.1f;
        lR.endWidth = 0.1f;
        lR.positionCount = 2;
        lR.useWorldSpace = true;
    }

    private void FixedUpdate()
    {
        lR.SetPosition(0, player1.position); 
        lR.SetPosition(1, player2.position);
    }


}
