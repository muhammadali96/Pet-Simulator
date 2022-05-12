using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{
    public HungerFillStatusBar hungerBar;
    public MoodFillStatusBar moodBar;
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
        else if (collision.gameObject.name.Contains("ball"))
        {
            moodBar.currentLevel += GameData.shopItems[2, 6];
        }
        else if (collision.gameObject.name.Contains("teddy"))
        {
            moodBar.currentLevel += GameData.shopItems[2, 7];
        }
        else if (collision.gameObject.name.Contains("duck"))
        {
            moodBar.currentLevel += GameData.shopItems[2, 8];
        }
        else if (collision.gameObject.name.Contains("wool"))
        {
            moodBar.currentLevel += GameData.shopItems[2, 9];
        }
        else if (collision.gameObject.name.Contains("hand"))
        {
            moodBar.currentLevel += GameData.shopItems[2, 6];
        }
        else
        {
            Debug.LogError("Could not increment Bars, check Detect collision mechanics");
        }
        this.GetComponent<Animator>().SetTrigger("Eating");

        Destroy(collision.gameObject);
    }
}
