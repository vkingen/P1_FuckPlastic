using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCollider : MonoBehaviour
{
    //public Transform resetPlayerPos;
    //public Transform resetBolderPos;
    public GameObject player, player2;
    //public GameObject newPlayer, newPlayer2;
    public int waitSeconds = 1;

    private int playerOneLives;

    private int playerTwoLives;



    //public GameObject bolderPlayer, bolderPlayer2;
    //public GameObject ropeSolver, ropeSolver2;


    MultiTargetCamera mTC;

    //GameObject player1, player2;

    private void Start()
    {
        mTC = FindObjectOfType<MultiTargetCamera>();

        playerOneLives = GameObject.Find("Canvas").GetComponent<InGamePointSystem>().playerOneLives;
        playerTwoLives = GameObject.Find("Canvas").GetComponent<InGamePointSystem>().playerTwoLives;

        //GameObject.Find("Canvas").GetComponent<InGamePointSystem>().PlayerOneWins();
        


    }

    IEnumerator LoadOnDelay() //Forsinker 'reload' a scenen, med x antal sekunder. 
    {
        yield return new WaitForSeconds(waitSeconds);
        //Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(playerOneLives > 0)
            {

                InGamePointSystem.instance.RemoveLifePlayerOne();

                //Destroy(player.gameObject);

                //Instantiate(newPlayer, new Vector3(0, 5, 0), Quaternion.identity);

                //if (player == null)

                //player.transform.position = resetPlayerPos.position;
                //bolderPlayer.transform.position = resetBolderPos.position;
                //ropeSolver.transform.position = resetPlayerPos.position;


                //mTC.targets.Remove();
                mTC.targets.Clear();
                //mTC.CenterPositionOfCameraOnDeath();
                mTC.isDead = true;
                //Destroy(other.gameObject);
                //other.gameObject
                Debug.Log("Player one is dead");

                StartCoroutine(LoadOnDelay());
            }
            else
            {
                
            }
           
        }
        if (other.tag == "Player2")
        {
            if (playerTwoLives > 0)
            {
                InGamePointSystem.instance.RemoveLifePlayerTwo();

                //player2.transform.position = resetPlayerPos.position;
                //bolderPlayer2.transform.position = resetBolderPos.position;
                //ropeSolver2.transform.position = resetPlayerPos.position;

                mTC.targets.Clear();
                //mTC.CenterPositionOfCameraOnDeath();
                mTC.isDead = true;
                //Destroy(other.gameObject);
                Debug.Log("Player two is dead");

                StartCoroutine(LoadOnDelay());
            }
                
        }
    }
}
