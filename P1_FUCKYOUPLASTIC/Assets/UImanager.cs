using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public Text fightText;
    public int timer = 3;


    private void Start()
    {
        fightText.text = timer.ToString();
        StartCoroutine(Delay());
    }

    IEnumerator fightDelay()
    {
        fightText.text = "FIGHT!";
        yield return new WaitForSeconds(1f);
        fightText.text = "";
    }


    IEnumerator Delay()
    {

        yield return new WaitForSeconds(1f);
        timer--;

        if (timer > 0)
        {
            fightText.text = timer.ToString();
            StartCoroutine(Delay());
        }
        else
        {
            StartCoroutine(fightDelay());
        }
        

    }
















}
