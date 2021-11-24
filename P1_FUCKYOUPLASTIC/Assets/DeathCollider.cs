using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollider : MonoBehaviour
{
    //public Transform resetPlayerPos;
    //public Transform resetBolderPos;
    public GameObject player, player2;
    public GameObject newPlayer, newPlayer2;

    //public GameObject bolderPlayer, bolderPlayer2;
    //public GameObject ropeSolver, ropeSolver2;


    //MultiTargetCamera mTC;

    //GameObject player1, player2;

    private void Start()
    {
        //mTC = FindObjectOfType<MultiTargetCamera>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            InGamePointSystem.instance.RemoveLifePlayerOne();

            Destroy(player.gameObject);

            Instantiate(newPlayer, new Vector3(0, 5, 0), Quaternion.identity);

         //if (player == null)




                //player.transform.position = resetPlayerPos.position;
                //bolderPlayer.transform.position = resetBolderPos.position;
                //ropeSolver.transform.position = resetPlayerPos.position;


                //mTC.targets.Remove();
                //mTC.targets.Clear();
                //mTC.CenterPositionOfCameraOnDeath();
                //mTC.isDead = true;
                //Destroy(other.gameObject);
                //other.gameObject
                Debug.Log("Player one is dead");           
        }
        if (other.tag == "Player2")
        {
            InGamePointSystem.instance.RemoveLifePlayerTwo();

            //player2.transform.position = resetPlayerPos.position;
            //bolderPlayer2.transform.position = resetBolderPos.position;
            //ropeSolver2.transform.position = resetPlayerPos.position;

            //mTC.targets.Clear();
            //mTC.CenterPositionOfCameraOnDeath();
            //mTC.isDead = true;
            //Destroy(other.gameObject);
            Debug.Log("Player two is dead");
        }
    }
}
