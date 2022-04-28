using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{
    public HungerFillStatusBar hungerBar;
    public GameObject InventoryManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name.Contains("bread")) 
        {
            hungerBar.currentLevel+= InventoryManager.GetComponent<InventoryManagerScript>().shopItems[2, 1];
        }
        else if (collision.gameObject.name.Contains("apple"))
        {
            hungerBar.currentLevel += InventoryManager.GetComponent<InventoryManagerScript>().shopItems[2, 2];
        }
        else
        {
            Debug.LogError("Could not increment Hunger Bar, check prefabs");
        }

        Destroy(collision.gameObject);
    }
}
