using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenuUI_Aske : MonoBehaviour
{
    // Welcome screen
    public Text titleText;
    string box1 = "Choose your characters";
    string box2 = "Settings";
    private float score = 5;

    // Won screen
    public bool showWinScreen = false;
    string winningText = "You won!";
    string losingText = "You lose!";

    // Update is called once per frame
    void Update()
    {
        titleText.text = "Welcome to *game name*!" + score;
    }
}
