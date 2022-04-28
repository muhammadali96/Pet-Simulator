using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[6, 6];
    public List<GameObject> newGameObj;
    public MoveScript moveScript;
   


    void Start()
    {

        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;

        //Stats
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
        int ItemID = ButtonRef.GetComponent<InventoryButtonInfo>().ItemID;

        if (shopItems[3, ItemID] >= 1)
        {
            //randomly place this gameobject in the map where the pet can travel

            float x = Random.Range(moveScript.xLowerBound, moveScript.xUpperBound);
            float y = Random.Range(moveScript.yLowerBound, moveScript.yUpperBound);

            Instantiate(newGameObj[ItemID-1] , new Vector3(x, y, 0), Quaternion.identity);

            shopItems[3, ItemID]--;
            ButtonRef.GetComponent<InventoryButtonInfo>().QuantityTxt.text = shopItems[3, ButtonRef.GetComponent<InventoryButtonInfo>().ItemID].ToString();
        }

    }
}
