using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGamePointSystem : MonoBehaviour
{
    public static InGamePointSystem instance;

    public int playerLives = 3;
    public int playerOneLives, playerTwoLives;
    private int removeLife = 1;

    public Text playerOneLivesText, playerTwoLivesText;

    public string lifeText = "Lives: ";

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        playerOneLives = playerLives;
        playerTwoLives = playerLives;

        playerOneLivesText.text = lifeText + playerOneLives.ToString();
        playerTwoLivesText.text = lifeText + playerTwoLives.ToString();
    }


    public void RemoveLifePlayerOne()
    {
        playerOneLives -= removeLife;
        playerOneLivesText.text = lifeText + playerOneLives.ToString();
    }

    public void RemoveLifePlayerTwo()
    {
        playerTwoLives -= removeLife;
        playerTwoLivesText.text = lifeText + playerTwoLives.ToString();
    }

}
