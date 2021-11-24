using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior_Aske : MonoBehaviour
{
    // Welcome screen
    string labelText = "Welcome to *game name*!";
    string box1 = "Choose your characters";
    string box2 = "Settings";

    // Won screen
    public bool showWinScreen = false;

    void OnGUI()
    {
        // 4
        GUI.Box(new Rect(20, 20, 150, 25), box1);
        // 5
        GUI.Box(new Rect(20, 50, 150, 25), box2);
        // 6
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height -
        50, 300, 50), labelText);
    }
}

// Start is called before the first frame update
//void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}
