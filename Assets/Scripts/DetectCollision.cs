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

        if (collision.gameObject.name.Contains("cake")) 
        {
            hungerBar.currentLevel+= GameData.shopItems[2, 1];
        }
        else if (collision.gameObject.name.Contains("meat"))
        {
            hungerBar.currentLevel += GameData.shopItems[2, 2];
        }
        else if (collision.gameObject.name.Contains("watermelon"))
        {
            hungerBar.currentLevel += GameData.shopItems[2, 3];
        }
        else if (collision.gameObject.name.Contains("burger"))
        {
            hungerBar.currentLevel += GameData.shopItems[2, 4];
        }
        else if (collision.gameObject.name.Contains("apple"))
        {
            hungerBar.currentLevel += GameData.shopItems[2, 5];
        }
        else
        {
            Debug.LogError("Could not increment Hunger Bar, check prefabs");
        }

        Destroy(collision.gameObject);
    }
}
