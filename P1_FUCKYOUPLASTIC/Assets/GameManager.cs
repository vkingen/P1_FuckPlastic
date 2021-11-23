using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text playerHealthText1, playerHealthText2;
    public int playerHealth1, playerHealth2;

    private void Start()
    {
        playerHealthText1.text = playerHealth1.ToString();
        playerHealthText2.text = playerHealth2.ToString();
    }

    public void DamagePlayer1()
    {
        playerHealth1 = playerHealth1 - 10;
        playerHealthText1.text = playerHealth1.ToString();
    }
    public void DamagePlayer2()
    {
        playerHealth2 = playerHealth2 - 10;
        playerHealthText2.text = playerHealth2.ToString();
    }
}
