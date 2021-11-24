using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// SceneManagement is used to manage the scene in Unity
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int addOne = 1;
    //PlayButton calls this method, which goes to the next scene in the row
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + addOne);
    }

    //QuitButton calls this method, which quits the game
    public void QuitGame ()
    {
        Application.Quit();
    }
}
