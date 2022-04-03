using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void CloseUpBack()
    {
        SceneManager.LoadScene("Home Scene");
    }
    public void ChangeLevel()
    {
        Debug.Log("changing level");
    }

    public void FeedPet()
    {
        Debug.Log("Feed Pet");
    }

    public void Breathe()
    {
        SceneManager.LoadScene("Task1");
    }
    public void Match3()
    {
        SceneManager.LoadScene("Game");
    }

    public void ClearData()
    {
        SaveSystem.ClearPlayer();
    }


}
