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

    public void ToggleHelp()
    {
        HelpPopUp.ActiveSelf = vale;
        HelpPopUp.SetActive(!vale);
    }
}
