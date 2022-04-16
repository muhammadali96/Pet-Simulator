using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventoryBar : MonoBehaviour
{

    public GameObject InventoryBar;

    public void Open()
    {
        if(InventoryBar != null)
        {
            bool isActive = InventoryBar.activeSelf;
            InventoryBar.SetActive(!isActive);
        }
    }
   
}
