using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior_Aske : MonoBehaviour
{
    // 1
    public string labelText = "Collect all 4 items and win your freedom!";
    public int maxItems = 4;
    private int _itemsCollected = 0;
    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;

            // 2
            if (_itemsCollected >= maxItems)
            {
                labelText = "You've found all the items!";
            }
            else
            {
                labelText = "Item found, only " + (maxItems -
                _itemsCollected) + " more to go!";
            }
        }
    }

    private int _playerHP = 3;
    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            Debug.LogFormat("Lives: {0}", _playerHP);
        }
    }

    // 3
    void OnGUI()
    {
        // 4
        GUI.Box(new Rect(20, 20, 150, 25), "Player Health:" +
         _playerHP);
        // 5
        GUI.Box(new Rect(20, 50, 150, 25), "Items Collected: " +
        _itemsCollected);
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
