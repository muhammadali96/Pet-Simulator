using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventoryBar : MonoBehaviour
{

    public GameObject InventoryBar;
    public GameObject InactiveInventoryBar;

    public void Open()
    {
        if(InventoryBar != null)
        {
            bool isActive = InventoryBar.activeSelf;
            InventoryBar.SetActive(!isActive);
            InactiveInventoryBar.SetActive(false);
        }
    }
   
}
