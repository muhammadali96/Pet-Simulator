using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStartMap : MonoBehaviour
{
   
   public void StartGame()
    {
        Debug.Log("starting game");
        SceneManager.LoadScene("Level1");
    }
}
