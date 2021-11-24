using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UImanager : MonoBehaviour
{
    public TMP_Text fightText;
    public int timer = 3;
    BoatMove[] movementsToFreeze;

    AudioSource aS;


    private void Start()
    {
        aS = GetComponent<AudioSource>();
        aS.Play();
        movementsToFreeze = FindObjectsOfType<BoatMove>();
        for (int i = 0; i < movementsToFreeze.Length; i++)
        {
            movementsToFreeze[i].isMoving = false;
        }
        fightText.text = timer.ToString();
        StartCoroutine(Delay());
    }

    IEnumerator fightDelay()
    {
        fightText.text = "FIGHT!";
        for (int i = 0; i < movementsToFreeze.Length; i++)
        {
            movementsToFreeze[i].isMoving = true;
        }
        aS.pitch += 1;
        aS.Play();
        yield return new WaitForSeconds(1f);
        fightText.text = "";
    }


    IEnumerator Delay()
    {

        yield return new WaitForSeconds(1f);
        timer--;

        if (timer > 0)
        {
            aS.Play();
            fightText.text = timer.ToString();
            StartCoroutine(Delay());
        }
        else
        {
            StartCoroutine(fightDelay());
        }
        

    }
















}
