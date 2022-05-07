using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{

    public float coins;
    public Text CoinsTXT;


    void Start()
    {
      
        CoinsTXT.text = "Coins:" + coins.ToString();



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
