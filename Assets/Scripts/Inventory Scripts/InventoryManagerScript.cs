using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryManagerScript : MonoBehaviour
{


    public List<GameObject> newGameObj;
    public MoveScript moveScript;

    public float xItemsLowerBound = -2.5f;
    public float yItemsUpperBound = -0.6f;


    public void Use()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        int ItemID = ButtonRef.GetComponent<InventoryButtonInfo>().ItemID;

        if (GameData.shopItems[3, ItemID] >= 1)
        {
            //randomly place this gameobject in the map where the pet can travel

            float x = Random.Range(xItemsLowerBound, moveScript.xUpperBound);
            float y = Random.Range(moveScript.yLowerBound, yItemsUpperBound);

            Instantiate(newGameObj[ItemID-1] , new Vector3(x, y, 0), Quaternion.identity);

            GameData.shopItems[3, ItemID]--;
            ButtonRef.GetComponent<InventoryButtonInfo>().QuantityTxt.text = GameData.shopItems[3, ButtonRef.GetComponent<InventoryButtonInfo>().ItemID].ToString();
        }

    }
}
