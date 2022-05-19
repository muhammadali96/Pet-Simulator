using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CBTButtonManager : MonoBehaviour
{
    public GameObject PopUp;
    public GameObject HelpPopUp;

   public void GoToNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ClosePopup()
    {
        PopUp.SetActive(false);
    }

    public void GoToIntro()
    {
        SceneManager.LoadScene("Intro help");
    }
        
    public void GoToNegativeHelp()
    {
        SceneManager.LoadScene("Negative help");
    }

    public void GoToPositiveHelp()
    {
        SceneManager.LoadScene("Positive help scene");
    }

    public void GoToCbtInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void GoToHelp()
    {
        SceneManager.LoadScene("Help scene");
    }

    }
