using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    //Stores IDs, price&mana, quantity within array
    public static int[,] shopItems = new int[11, 11];
    //store coins (starting purse)
    public static float coins = 100;

    public void Awake()
    {
        DontDestroyOnLoad(this);
        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        shopItems[1, 6] = 6;
        shopItems[1, 7] = 7;
        shopItems[1, 8] = 8;
        shopItems[1, 9] = 9;
        shopItems[1, 10] = 10;

        //Price & Mana
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 40;
        shopItems[2, 5] = 50;
        shopItems[2, 6] = 10;
        shopItems[2, 7] = 20;
        shopItems[2, 8] = 30;
        shopItems[2, 9] = 40;
        shopItems[2, 10] = 50;


    }

   
}
