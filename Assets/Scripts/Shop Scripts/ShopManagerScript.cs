using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{

    //public int[,] shopItems = new int[6,6];
    public float coins;
    public Text CoinsTXT;


    void Start()
    {
      
        CoinsTXT.text = "Coins:" + coins.ToString();


        ////ID's
        //GameData.shopItems[1, 1] = 1;
        //GameData.shopItems[1, 2] = 2;
        //GameData.shopItems[1, 3] = 3;
        //GameData.shopItems[1, 4] = 4;
        //GameData.shopItems[1, 5] = 5;

        ////Price
        //GameData.shopItems[2, 1] = 10;
        //GameData.shopItems[2, 2] = 20;
        //GameData.shopItems[2, 3] = 30;
        //GameData.shopItems[2, 4] = 40;
        //GameData.shopItems[2, 5] = 50;

        ////Quantity
        //GameData.shopItems[3, 1] = 0;
        //GameData.shopItems[3, 2] = 0;
        //GameData.shopItems[3, 3] = 0;
        //GameData.shopItems[3, 4] = 0;
        //GameData.shopItems[3, 5] = 0;

    }


    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (coins >= GameData.shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            coins -= GameData.shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            GameData.shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            CoinsTXT.text = "Coins:" + coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = GameData.shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();

        }


    }
}
