using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGamePointSystem : MonoBehaviour
{
    public int playerOnePoints, playerTwoPoints;
    private int addPoint = 1;
    public Text playerOnePointsText, playerTwoPointsText;
    public string scoreText = "Score: ";

    public static InGamePointSystem instance;

    // Start is called before the first frame update
    void Start()
    {
        playerOnePointsText.text = scoreText + playerOnePoints.ToString();
        playerTwoPointsText.text = scoreText + playerTwoPoints.ToString();
    }


    public void AddPointPlayerOne()
    {
        playerOnePoints += addPoint;
        playerOnePointsText.text = scoreText + playerOnePoints.ToString();
    }

    public void AddPointPlayerTwo()
    {
        playerTwoPoints += addPoint;
        playerTwoPointsText.text = scoreText + playerTwoPoints.ToString();
    }

}
