using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//https://www.youtube.com/watch?v=YUcvy9PHeXs
public class InGamePointSystem : MonoBehaviour
{
    public static InGamePointSystem instance;

    //public int playerLives = 3;
    public int playerOneLives = 3; 
    public int playerTwoLives = 3;
    private int removeLife = 1;


    public Text playerOneLivesText, playerTwoLivesText;


    public string lifeText = "Lives: ";
    

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        //playerOneLives = playerLives;
        //playerTwoLives = playerLives;
        

        playerOneLivesText.text = lifeText + playerOneLives.ToString();
        playerTwoLivesText.text = lifeText + playerTwoLives.ToString();
    }

    private void Update()
    {
        if (playerOneLives == 0)
        {
            playerOneLives = 3;
            SceneManager.LoadScene("P2Wins");
        }
        else if(playerTwoLives == 0)
        {
            playerTwoLives = 3;
            SceneManager.LoadScene("P1Wins");
        }


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
