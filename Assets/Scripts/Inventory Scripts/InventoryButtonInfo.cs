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
    //can you share or refer ro the same GameObjects across scenes?

    void Update()
    {
        StatsTxt.text = "+" + InventoryManager.GetComponent<InventoryManagerScript>().shopItems[2, ItemID].ToString();
        QuantityTxt.text = InventoryManager.GetComponent<InventoryManagerScript>().shopItems[3, ItemID].ToString();
    }
}
