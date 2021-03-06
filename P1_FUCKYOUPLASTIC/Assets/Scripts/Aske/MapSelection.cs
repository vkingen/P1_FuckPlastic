using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// SceneManagement is used to manage the scene in Unity
using UnityEngine.SceneManagement;

public class MapSelection : MonoBehaviour
{
    private int addOne = 1;
    //The Island button in UI calls the Island method which loads the scene Island.
    public void Road()
    {
        SceneManager.LoadScene("RoadMap");
    }

    //The space button in UI calls the Space method which loads the scene Space.
    public void Space()
    {
        SceneManager.LoadScene("SpaceMap");
    }

    public void Pyramid()
    {
        SceneManager.LoadScene("PyramidMap");
    }
}
