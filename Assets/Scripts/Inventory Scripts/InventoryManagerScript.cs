using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[6, 6];
    public float hunger;


    void Start()
    {

        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;

        //Price
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 40;
        shopItems[2, 5] = 50;

        //Quantity
        shopItems[3, 1] = 10;
        shopItems[3, 2] = 10;
        shopItems[3, 3] = 10;
        shopItems[3, 4] = 10;
        shopItems[3, 5] = 10;

    }


    public void Use()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (shopItems[3, ButtonRef.GetComponent<InventoryButtonInfo>().ItemID] >= 1)
        {
            hunger += shopItems[2, ButtonRef.GetComponent<InventoryButtonInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<InventoryButtonInfo>().ItemID]--;
            ButtonRef.GetComponent<InventoryButtonInfo>().QuantityTxt.text = shopItems[3, ButtonRef.GetComponent<InventoryButtonInfo>().ItemID].ToString();
        }

    }
}
