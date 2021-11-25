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
    public GameObject healthIconP1, healthIconP2;


   // public string lifeText = "Lives: ";
    

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
        

        playerOneLivesText.text = playerOneLives.ToString();
        playerTwoLivesText.text = playerTwoLives.ToString();
    }

    private void Update()
    {
        if (playerOneLives == 0)
        {
            playerOneLives = 3;
            playerTwoLives = 3;
            playerOneLivesText.text = "";
            playerTwoLivesText.text = "";
            healthIconP1.SetActive(false);
            healthIconP2.SetActive(false);
            SceneManager.LoadScene("P2Wins");
        }
        else if(playerTwoLives == 0)
        {
            playerTwoLives = 3;
            playerOneLives = 3;
            playerTwoLivesText.text = "";
            playerOneLivesText.text = "";
            healthIconP1.SetActive(false);
            healthIconP2.SetActive(false);
            SceneManager.LoadScene("P1Wins");
        }


    }

    public void ShowUI()
    {
        playerOneLivesText.text = playerOneLives.ToString();
        playerTwoLivesText.text = playerTwoLives.ToString();
        healthIconP1.SetActive(true);
        healthIconP2.SetActive(true);
    }


    public void RemoveLifePlayerOne()
    {
        playerOneLives -= removeLife;
        playerOneLivesText.text = playerOneLives.ToString();
    }

    public void RemoveLifePlayerTwo()
    {
        playerTwoLives -= removeLife;
        playerTwoLivesText.text = playerTwoLives.ToString();
    }
}
