using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{
    public HungerFillStatusBar hungerBar;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hungerBar.currentLevel++;
        Destroy(collision.gameObject);
    }
}
