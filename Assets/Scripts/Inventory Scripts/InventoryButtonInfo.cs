using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButtonInfo : MonoBehaviour
{

    public int ItemID;
    public Text StatsTxt;
    public Text QuantityTxt;
    public GameObject InventoryManager;

    void Update()
    {
     
        StatsTxt.text = "+" + GameData.shopItems[2, ItemID].ToString();
        QuantityTxt.text = GameData.shopItems[3, ItemID].ToString();
    }
}
